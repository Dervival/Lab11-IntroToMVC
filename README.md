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
Create the internal logic to read in the file, filter the data from the given inputted range using LINQ queries and Lambda expressions, and return the final filtered list of persons.

#### Questions
1. Output all of the neighborhoods in this data list
1. Filter out all the neighborhoods that do not have any names
1. Remove the Duplicates
1. Rewrite the queries from above, and consolidate all into one single query.
1. Rewrite at least one of these questions only using the opposing method (example: Use LINQ instead of a Lambda and vice versa.)

#### Setup/Running instructions
- Clone or download this repository into a folder of your choice.
- Open up the solution file in an IDE of your choice, preferably Visual Studio
- Ensure the NuGet package NewtonSoftJson is installed as a dependency.
- Within your IDE, start the solution with or without debugging. Use the console window that opens to type in input.
- The program will run on its own.

#### Sample inputs:
- No sample inputs for this project.

#### Sample outputs:
- For Question 1:
What are all of the neighborhoods in this data list, including duplicates and null values?
Chelsea; Lower East Side; Gramercy Park; Financial District; Civic Center; Financial District; Tribeca; ; East Village; Gramercy Park; Chelsea; Greenwich Village, SoHo; SoHo, Tribeca; Greenwich Village; Kips Bay, Murray Hill; Midtown East; Garment District; Midtown West; Diamond District, Midtown; Upper East Side; Midtown East; Upper West Side; Upper West Side; Manhattan Valley; Harlem; Morningside Heights, Harlem; Upper East Side; Spanish Harlem; Harlem; Sugar Hill, Upper Manhattan; Washington Heights; Hudson Heights; Inwood; East Harlem; Hell's Kitchen; Harlem; Civic Center; Upper Manhattan; Hudson Heights; Financial District; Financial District; Roosevelt Island; Financial District; Midtown; Midtown; Hunter College, Rockefeller University; Upper West Side; Upper East Side; Battery Park City; Financial District; Midtown; Financial District; ; ; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Hell's Kitchen; Midtown; Midtown; Midtown; ; Chelsea; Manhattanville; Chelsea; Chelsea; Murray Hill; Garment District; Garment District; Garment District; Garment District; Garment District; Midtown; Upper West Side; Midtown; Carnegie Hill; Midtown; Yorkville; Lenox Hill; Upper West Side; Upper West Side; Chelsea; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Chelsea; Murray Hill; Kips Bay; Kips Bay; Financial District; Upper East Side; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Murray Hill; Midtown; Midtown; Midtown East; Murray Hill; Midtown; Midtown; Garment District; Financial District; East Village; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Gramercy Park; Financial District; Financial District; Financial District; South Cove; Battery Park City; Battery Park City; Battery Park City; Battery Park City; Battery Park City;
147 neighborhoods returned from the first query.

- For Question 2:
What are all of the neighborhoods in this data list, including duplicates?
Chelsea; Lower East Side; Gramercy Park; Financial District; Civic Center; Financial District; Tribeca; East Village; Gramercy Park; Chelsea; Greenwich Village, SoHo; SoHo, Tribeca; Greenwich Village; Kips Bay, Murray Hill; Midtown East; Garment District; Midtown West; Diamond District, Midtown; Upper East Side; Midtown East; Upper West Side; Upper West Side; Manhattan Valley; Harlem; Morningside Heights, Harlem; Upper East Side; Spanish Harlem; Harlem; Sugar Hill, Upper Manhattan; Washington Heights; Hudson Heights; Inwood; East Harlem; Hell's Kitchen; Harlem; Civic Center; Upper Manhattan; Hudson Heights; Financial District; Financial District; Roosevelt Island; Financial District; Midtown; Midtown; Hunter College, Rockefeller University; Upper West Side; Upper East Side; Battery Park City; Financial District; Midtown; Financial District; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Hell's Kitchen; Midtown; Midtown; Midtown; Chelsea; Manhattanville; Chelsea; Chelsea; Murray Hill; Garment District; Garment District; Garment District; Garment District; Garment District; Midtown; Upper West Side; Midtown; Carnegie Hill; Midtown; Yorkville; Lenox Hill; Upper West Side; Upper West Side; Chelsea; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Chelsea; Murray Hill; Kips Bay; Kips Bay; Financial District; Upper East Side; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Midtown; Murray Hill; Midtown; Midtown; Midtown East; Murray Hill; Midtown; Midtown; Garment District; Financial District; East Village; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Financial District; Gramercy Park; Financial District; Financial District; Financial District; South Cove; Battery Park City; Battery Park City; Battery Park City; Battery Park City; Battery Park City;
143 neighborhoods returned from the second query.

- For Question 3:
What are all of the neighborhoods in this data list?
Chelsea; Lower East Side; Gramercy Park; Financial District; Civic Center; Tribeca; East Village; Greenwich Village, SoHo; SoHo, Tribeca; Greenwich Village; Kips Bay, Murray Hill; Midtown East; Garment District; Midtown West; Diamond District, Midtown; Upper East Side; Upper West Side; Manhattan Valley; Harlem; Morningside Heights, Harlem; Spanish Harlem; Sugar Hill, Upper Manhattan; Washington Heights; Hudson Heights; Inwood; East Harlem; Hell's Kitchen; Upper Manhattan; Roosevelt Island; Midtown; Hunter College, Rockefeller University; Battery Park City; Manhattanville; Murray Hill; Carnegie Hill; Yorkville; Lenox Hill; Kips Bay; South Cove;
39 neighborhoods returned from the third query.

- For Question 4:

What are all of the neighborhoods in this data list?
Chelsea; Lower East Side; Gramercy Park; Financial District; Civic Center; Tribeca; East Village; Greenwich Village, SoHo; SoHo, Tribeca; Greenwich Village; Kips Bay, Murray Hill; Midtown East; Garment District; Midtown West; Diamond District, Midtown; Upper East Side; Upper West Side; Manhattan Valley; Harlem; Morningside Heights, Harlem; Spanish Harlem; Sugar Hill, Upper Manhattan; Washington Heights; Hudson Heights; Inwood; East Harlem; Hell's Kitchen; Upper Manhattan; Roosevelt Island; Midtown; Hunter College, Rockefeller University; Battery Park City; Manhattanville; Murray Hill; Carnegie Hill; Yorkville; Lenox Hill; Kips Bay; South Cove;
39 neighborhoods returned from the fourth query.

- For Question 5:
What are all of the neighborhoods in this data list?
Chelsea; Lower East Side; Gramercy Park; Financial District; Civic Center; Tribeca; East Village; Greenwich Village, SoHo; SoHo, Tribeca; Greenwich Village; Kips Bay, Murray Hill; Midtown East; Garment District; Midtown West; Diamond District, Midtown; Upper East Side; Upper West Side; Manhattan Valley; Harlem; Morningside Heights, Harlem; Spanish Harlem; Sugar Hill, Upper Manhattan; Washington Heights; Hudson Heights; Inwood; East Harlem; Hell's Kitchen; Upper Manhattan; Roosevelt Island; Midtown; Hunter College, Rockefeller University; Battery Park City; Manhattanville; Murray Hill; Carnegie Hill; Yorkville; Lenox Hill; Kips Bay; South Cove;
39 neighborhoods returned from the fifth query.

#### Screen captures:
- ![Output](https://github.com/Dervival/Lab08-LINQinManhattan/blob/master/Output.PNG);
