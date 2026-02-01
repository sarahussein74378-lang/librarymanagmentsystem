namespace librarymanagmentsystem
{
    internal class Program
    {
        
            static void Main()
            {
            Library library = new Library();
                library.AddBook(new Book("Clean Code", "Robert Martin", "111",true));
                library.AddBook(new Book("C# Basics", "Ahmed Ali", "222",false));
                library.SearchBook("code"); 
                library.BorrowBook("111");
                library.BorrowBook("111");

                library.ReturnBook("111");

                Console.ReadLine();
            }
        }
    }
    

