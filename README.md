# Citrus Lime Code Challenge

This is my solution for the Citrus Lime code challenge

# Requirements
* Visual Studio 2019

# Instructions
* Run the application from VS
  * I recommend maximising the window, as the output WILL encompass the whole console.
* Input the number of the task (1 or 2).
* Input the page number and page size, or leave blank for default values (1 and 10, respectively).
  * Meaningful data typically only appears after page 4 on page size 10. It'll still work, but there will be a lot of blank fields.

# Notes
* Despite only 2 of the tasks being selectable, all 3 tasks are accounted for. Task 3 had to be merged into 2 out of necessity due to rate limiting errors. So consider task 2 to be my solution to both 2 and 3
* The grid will truncate descriptions if they are particularly long.
* Task 3 (2)'s solution involves use of a retry policy, with a maximum retry count, but more importantly a retry wait time between failed requests. This defaults to 1 second. For this reason, large page requests may take a very long time to retrieve everything.

# Acknowledgements
* Grid view: https://stackoverflow.com/questions/856845/how-to-best-way-to-draw-table-in-console-app-c
