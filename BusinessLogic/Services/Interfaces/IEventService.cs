using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Services.Interfaces
{
    /// <summary>
    /// Interface for ItemService. Retrieves all item- and related data from web api
    /// </summary>
    public interface IEventService
    {
        /// <summary>
        /// Async function to return a list of Item objects from the web API
        /// </summary>
        /// <returns>A list of Item objects</returns>
        public List<Event> getEvents();
    }
}
