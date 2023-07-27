namespace library.Books
{
    public class Book
    {
        #region Variabls
        public string Name { get; set; }
        public string Author { get; set; }
        #endregion
        public virtual void PrintInfo()
        {
            Console.WriteLine("Book Name : " +  Name + "\n Book Author :" + Author);
        }

    }
}
