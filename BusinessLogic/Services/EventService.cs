using BusinessLogic.Models;
using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using HtmlAgilityPack;
using System.Configuration;
using System.Linq;
using BusinessLogic.Helpers.Enums;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Service class that scrapes data from website
    /// </summary>
    public class EventService : IEventService
    {
        /// <summary>
        /// Private Web scraper object
        /// </summary>
        HtmlWeb _webScraper;

        /// <summary>
        /// Constructor for EventService. Takes a new web scraper object from an injector class (if one exists)
        /// </summary>
        /// <param name="context">An HtmlWeb object defined in injector class</param>
        public EventService(HtmlWeb webScraper)
        {
            _webScraper = webScraper;
        }

        /// <summary>
        /// Default constructor for EventService. Defines a new web scraper
        /// </summary>
        public EventService()
        {
            _webScraper = new HtmlWeb();
        }

        /// <summary>
        /// Async function to return a list of Event objects from the website
        /// </summary>
        /// <returns>A list of Event objects</returns>
        public List<Event> getEvents()
        {
            try
            {
                List<Event> EventList = new List<Event>();
                var scraper = new HtmlWeb();
                var config = ConfigurationManager.AppSettings;
                var page = _webScraper.Load(Constants.url);
                var nodes = page.DocumentNode.Descendants().Where(e => e.HasClass("g-blocklist-item"));

                foreach (var currNode in nodes)
                {
                    Event newEvent = new Event();

                    var ImageUrl = currNode.Descendants().Where(e => e.Name == "img").DefaultIfEmpty().FirstOrDefault();

                    newEvent.EventName = currNode.Descendants().Where(e => e.HasClass("g-blocklist-link")).DefaultIfEmpty().First().GetAttributeValue("title", "");
                    if (ImageUrl != null)
                    {
                        newEvent.ImageUrl = ImageUrl.GetAttributeValue("data-src", "");
                    }
                    var venue = currNode.Descendants().Where(e => e.HasClass("g-blocklist-sub-text")).DefaultIfEmpty().First().InnerText.Split("\r\n");
                    newEvent.Status = currNode.Descendants().Where(e => e.HasClass("g-blocklist-action")).DefaultIfEmpty().First().InnerText.Split("\r\n")[1].Trim();
                    newEvent.Venue = currNode.Descendants().Where(e => e.HasClass("g-blocklist-sub-text")).DefaultIfEmpty().First().InnerText.Split("\r\n")[4].Trim();

                    var DatePart = venue[6].Trim();
                    var TimePart = venue[7].Trim();

                    DateTime d = DateTime.Parse(DatePart + TimePart);
                    newEvent.Date = d;

                    EventList.Add(newEvent);
                }

                return EventList;
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception has occurred: ", e.Message);

                return null;
            }
        }
    }
}
