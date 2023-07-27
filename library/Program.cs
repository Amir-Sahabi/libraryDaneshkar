using library.Books;
using library.Clients;

namespace library
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region list of books
            List<String> listofbooks = new List<String>();
            #endregion

            #region Manager
            Manager mng = new Manager();
            mng.name = "Frank";
            mng.email = "FrankCastle@punisher.com";
            #endregion

            #region Clients

            Client client01 = mng.AddClient("john","john@yahoo.com");


            Client client02 = mng.AddClient("Rohny", "Rohny@yahoo.com");

            #endregion

            #region New Book
            Book Book01 = mng.AddBook("Harry Potter", " J. K. Rowling ");
            listofbooks.Add(Book01.Name);

            Book Book02 = mng.AddBook("The 48 Laws of Power", "Robert Greene");
            listofbooks.Add(Book02.Name);

            Book Book03 = mng.AddBook("A Tale of Two Cities", "Charles Dickens");
            listofbooks.Add(Book03.Name);
            #endregion

            #region Show listofbooks

            if (listofbooks.Count > 0)
            {
                foreach (var el in listofbooks)
                    Console.WriteLine(el);
            }
            #endregion

            #region Search for book

            mng.SearchBook("Harry Potter");

            #endregion


        }
    }
}