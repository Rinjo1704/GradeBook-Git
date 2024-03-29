using GradeBook1;
using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ValueTypesAlsoPassByValue();
        
        
        
        
        
        
        [Fact]
        public void CSharpIsPassByValue()
        {

            var book1 = GetBook("Book 1");
            GetBookSetName(book1, " New Name");


            Assert.Equal("Book 1", book1.Name);

             void GetBookSetName(ref Book book, string name)
             {
                book = new Book(name);

             }
        
            [Fact]
        public void CSharpIsPassByValue()
        {

            var book1 = GetBook("Book 1");
            GetBookSetName(book1, " New Name");


            Assert.Equal("Book 1", book1.Name);
        
            privet void GetBookSetName(Book book, string name )
            {
                book = new Book(name);
                
            }

        [Fact]
        public void CanSetNameFromReference()
        {

            var book1 = GetBook("Book 1");
            SetName(book1, " New Name");


            Assert.Equal("New Name", book1.Name);
            
         
           void SetName(Book book1, string name)
           {
                book.Name = name;
           }

        [Fact]
        
        public void GetBookReturnsDifferentObjects()
        {

            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");


            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1,book2);
        }
        [Fact]
        public void TowVariableCanReferencSameObject()
        {

            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(object.ReferenceEquals(book1, book2));
             



            /*Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            */
        }
        Book GetBook(string name)
        {
            return new Book(name);
        }







        
    } 
}
