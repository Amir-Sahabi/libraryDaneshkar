using library.Books;
using library;
namespace library.Clients
{
    public class Manager : Person
    {
        #region Add Client
        public Client AddClient(string Clientname, string cllientemail)
        {
            Client client1 = new Client();

            client1.name = Clientname;

            client1.email = cllientemail;

            return client1;

        }

        #endregion

        #region AddBook 
        public Book AddBook(string BookName, string BookAuthor)
        {
            Book book1 = new Book();
            
            book1.Name = BookName;
            
            book1.Author = BookAuthor;
            
            return book1;

        }

        #endregion

        #region Search Books

        public void SearchBook(string BookName)
        {
            // search in list of books 
        }



        #endregion

    }
}
