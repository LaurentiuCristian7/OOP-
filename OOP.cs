using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_HOMEWORK
{
    //  public class Book
    // {
    //-----------ex1-------------
    //  Create a class Book with one constructor and the following fields:
    // - Title
    //  - Author
    //  - Year

    // Add the following methods:
    // - GetTitle() - returns the book's title.
    // - GetAuthor() - returns the book's author.
    //- GetYear() - returns the year the book was published.
    ////- SetTitle(string title) - sets the book's title.
    //- SetAuthor(string author) - sets the book's author.
    //  - SetYear(int year) - sets the year the book was published.

    //  public string Title;
    //   public string Author;
    //   public int Year;

    //   public Book (string title, string author, int year)
    //    {
    //     this.Title=title;
    //     this.Author=author;
    //     this.Year=year;
    //   }

    //   public string GetTitle()
    //   {
    //       return Title;
    //   }
    //   public string GetAuthor()
    //   {
    //       return Author;
    //   }
    //   public int GetYear()
    //   {
    //       return Year;
    //   }

    //   public void setTitle(string title)
    //   {
    //       Title="Anna Karenina";
    //   }
    //   public void setAuthor(string author)
    //   {
    //       Author="Lev Tolstoi";
    //   }
    //   public void setYear(int year)
    //   {
    //       Year=1877;
    //   }
    ////   public void Info()
    //   {
    //       string textToShow = $"The name of book is {this.Title},the name of author is {this.Author},the year of book is {this.Year}";
    //       Console.WriteLine(textToShow);
    //   }


    //  }
    //=====ex2========
    // Create a class Product with one constructor and the following fields:
    //- Name
    //- Price
    //- Quantity

    //Add the following methods:
    //- GetName() - returns the product's name.
    ///- GetPrice() - returns the product's price.
    //- GetQuantity() - returns the product's quantity.
    //- SetName(string name) - sets the product's name.
    //- SetPrice(double price) - sets the product's price.
    //- SetQuantity(int quantity) - sets the product's quantity.
    //The following program should work after you implement missing classes:

    //Product product = new Product("Apple", 0.99, 10);

    // Console.WriteLine(product.GetName()); // Outputs "Apple"
    //Console.WriteLine(product.GetPrice()); // Outputs 0.99
    //Console.WriteLine(product.GetQuantity()); // Outputs 10

    ///product.SetName("Orange");
    //product.SetPrice(1.49);
    //product.SetQuantity(20);

    //Console.WriteLine(product.GetName()); // Outputs "Orange"
    //Console.WriteLine(product.GetPrice()); // Outputs 1.49
    //Console.WriteLine(product.GetQuantity()); // Outputs 20  
    // public class Product
    //{
    //    public string Name;
    //    public double Price;
    //    public int Quantity;

    //    public Product( string name ,double price,int quantity)

    //    {
    //     this.Name = name;
    //     this.Price = price;
    //     this.Quantity = quantity;
    //   }

    //   public string GetName()
    //   {
    //      return Name;
    //   }

    //    public double GetPrice()
    //    {
    //        return Price;
    //    }

    //    public int GetQuantity()
    //    {
    //        return Quantity;
    //    }

    //    public void SetName(string name )
    //    {
    //      Name="Orange";
    //    }
    //    public void SetPrice(float price)
    //   {
    //      Price=1.49;
    //   }
    //   public void SetQuantity(int quantity)
    //   {
    //     Quantity=20;
    //   }
    //   public void Info()
    //   {
    //      string textToShow = $"The name of product is {this.Name},the price of product is {this.Price},the quantity of product is {this.Quantity}";
    //     Console.WriteLine(textToShow);
    //   }


    //  }

    // Exercise 3:

    //Create a class Animal with one constructor and the following fields:
    //- Species
    //- Breed
    //- Age
    //- Color
    //- Weight
    //- IsSpayedOrNeutered

    //Add the following methods:
    //- GetName() - returns the animal's name.
    //- GetSpecies() - returns the animal's species.
    //- GetBreed() - returns the animal's breed.
    //- GetAge() - returns the animal's age.
    //- GetColor() - returns the animal's color.
    //- GetWeight() - returns the animal's weight.
    //- IsSpayedOrNeutered() - returns a boolean value indicating whether the animal has been spayed or neutered.
    //- SetName(string name) - sets the animal's name.
    //- SetSpecies(string species) - sets the animal's species.
    //- SetBreed(string breed) - sets the animal's breed.
    ///- SetAge(int age) - sets the animal's age.
    //- SetColor(string color) - sets the animal's color.
    //- SetWeight(double weight) - sets the animal's weight.
    //- SetIsSpayedOrNeutered(bool isSpayedOrNeutered) - sets a boolean value indicating whether the animal has been spayed or neutered.


    /* public class Animal
     {
         public string Name;
         public string Species;
         public string Breed;
         public int Age;
         public string Color;
         public double Weight;
         public bool IsSpayedorNeutered;

         public Animal( string name ,string species, string breed, int age, string color, double weight,bool isspayedorneutered)
         {
             this.Name = name;
             this.Species=species;
             this. Breed=breed;
             this.Age=age;
             this.Color=color;
             this.Weight=weight;
             this.IsSpayedorNeutered=isspayedorneutered;

         }
         public string GetName()
         {
             return this.Name;   
         }

          public string GetSpecies()
          { 
             return Species; 
          }
         public string GetBreed()
         {
             return Breed;
         }
         public int GetAge()
         {
             return Age;
         }
         public string GetColor()
         {
             return Color;
         }
         public double GetWeight()
         {
             return Weight;
         }
         public bool IsSpayedOrNeutered()
         {
             if (Age<=2)
             {
                 return true;
             }

             else
             {
                 return false;
             }

         }
         public void SetName(string name)
         {
             Name="Buddy";
         }

         public void SetSpecies(string species)
         {
           Species="Cat";
         }
         public void SetBreed(string breed)
         {
             Breed=breed;
         }
         public void SetAge(int age )
         {
             Age=5;
         }
         public void SetColor(string color)
         {
             Color="gray";
         }
         public void SetWeight(int weight)
         {
             Weight=12;
         }
         public void SetIsSpayedOrNeutered(bool isspayedirneutered )
         {
             isspayedirneutered=IsSpayedorNeutered;
         }
         public void Info()
         {
             string textToShow = $"The name of animal is {this.Name},the species of animal is {this.Species},the breed of animal is {this.Breed},the age of animal is{this.Color},the color of animal is{this.Color},the weight of animal is {this.Weight}"; // the situatin of animal is {this.IsSpayedorNeutered}";
           Console.WriteLine(textToShow); //stiu ca nu trebuia ,dar am zis sa fie ....
        //*/ //}


    //}
    //  ex4
    /*Create a class Calculator with the following methods:

 - Add(int x, int y) - returns the sum of x and y.
 - Subtract(int x, int y) - returns the difference between x and y.
 - Multiply(int x, int y) - returns the product of x and y.
 - Divide(int x, int y) - returns the quotient of x and y.
 - Power(double x, double y) - returns x raised to the power of y.

 - SquareRoot(double x) - returns the square root of x.*/

    /* public class Calculator
     {
         public int x;
         public int y;

         public Calculator(int x, int y)
         {
             this. x = x;
             this.y = y; 

         }
         public int Add(int x,int y )
         {
             return x + y;
         }
         public int Subtract(int x, int y)
         {
              return x -y; 
         }
         public int Multiply(int x, int y)
         {
             return x*y;
         }
         public int Divide(int x, int y)
         {
             return x/y;
         }
         public double Power(int x, int y)
         {
             return Math.Pow(x, y);
         }
          public double SquareRoot(int x)
          {
             return Math.Sqrt(x);
          }*/


    //}
    /* Create a Student class that has the following fields: 
 - FirstName
 - LastName
 - StudentId
 - GPA

    The Student class should have the following methods:

    GetFullName() : returns the student's full name (i.e. first name followed by last name).
    HasHonors() : returns a boolean value indicating whether the student has a GPA of 3.5 or higher.

     Finally, create a Faculty class that has the following fields:
    - firstName
     - lastName
       - employeeId
     - subjectsTaught

     The Faculty class should have the following methods:

     GetFullName() : returns the faculty member's full name (i.e. first name followed by last name).
      GetSubjectsTaught() : returns a list of strings representing the subjects the faculty member teaches.

    Create a University class that has the following fields: 
    - Name
    - Students
    - Faculties

     The students property should be a list of Student objects, and the faculties property should be a list of Faculty objects.

    The University class should have the following methods:

     - AddStudent(student) : adds the specified Student object to the students list.
    - AddFaculty(faculty) : adds the specified Faculty object to the faculties list.
     - GetStudentCount() : returns the number of students at the university.
    - GetFacultyCount(): returns the number of faculties at the university.*/
    public class Student
    {
        public string FirstName;
        public string LastName;
        public long StudentId;
        public double GPA;

        public Student(string firstName, string lastName, long studentId, double gPa)
        {
            this.FirstName=firstName;
            this.LastName=lastName;
            this.StudentId=studentId;
            this.GPA=gPa;
        }

        public string GetFullName()
        {
            return this.FirstName;
            return this.LastName;
        }
        public bool HasHonors()
        {
            if (GPA <=3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
   
    
}





