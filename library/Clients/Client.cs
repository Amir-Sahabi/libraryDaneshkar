using library.Books;

namespace library.Clients
{
    public class Client : Person 
    {
        List <string> listofborrow = new List <string> ();

        #region Borrow Book
        public void BorrowBook(string Bookname)
        {
            // Borrow Book
            listofborrow.Add (Bookname);
        }
        #endregion

        #region Return Book

        public void Returnbook(string bookname)
        {
            //Retun Book
            
            string returned_book = bookname;
            listofborrow.Remove (returned_book);

        }

        #endregion

    }
}
