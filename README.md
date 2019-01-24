# Lab11-Intro to MVC and Core
Repository for my first MVC application - parsing a CSV file of people of the year from Time Magazine, and allowing a user to search and display a table of them based on a range of years inputted. 

#### Requirements
This MVC Web Application must contain the following:
- The MVC Middleware and include template routing with routes explicitly defined
- A single controller - the home controller, with 3 actions (2 Index, and 1 Results)
- Upon posting back to the server, call the Results action to redirect to the results view.
- Views to generate the home page and search results
- Use a form tag to accept user input
- Use Tag Helpers to help redirect you from results page to the Home page. (HINT: the _ViewImports.cshml file may be required)
- Include HTML/CSS in your final product. (It doesn’t have to be fancy, just make it look nice.)
- Enable use of Static Files in your website and create a style sheet and incorporate some creativity into your application.
- A model class named TimePerson that contains the following properties(these are the headers of the csv file):
- Create a static method within this model named GetPersons that brings in the range of years, and returns List<TimePerson>.
- Create the internal logic to read in the file, filter the data from the given inputted range using LINQ queries and Lambda expressions, and return the final filtered list of persons.

#### Setup/Running instructions
- Clone or download this repository into a folder of your choice.
- Open up the solution file in an IDE of your choice, preferably Visual Studio
- In the dropdown menu under the build button (top of the screen in the ribbon, second row, near the center, with the green triangle), make sure IIS express is selected.
- Click the build button, or hit F5.
- Enter two years between 1927 and 2016, inclusive. The second year must be no earlier than the first year.
- Hit the submit button.

#### Sample inputs:
- 1950 in the first field, 2000 in the second.

#### Sample outputs:
- A red, white, and blue table containing the information of Time People of the Year between the years 1950 and 2000 inclusive.

#### Screen captures:
- ![Input](https://github.com/Dervival/Lab11-IntroToMVC/blob/master/InputPage.PNG);
- ![Results](https://github.com/Dervival/Lab11-IntroToMVC/blob/master/ResultsPage.PNG);
