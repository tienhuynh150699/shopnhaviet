using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace BooksShopOnline.Models
{
    public class BookDatabaseInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "bàn ăn"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Ghế"
                }
            };
            return categories;
        }
        private static List<Book> GetBooks()
        {
            var books = new List<Book> {
                new Book
                {
                    BookID = 1,
                    BookName = "Bàn trà",
                    Description = "Phong cách hiện đại",
                    ImagePath ="bantra.jpg",
                    UnitPrice = 200000,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 2,
                    BookName = "Bàn ăn",
                    Description = "Phong cách đơn giản",
                    ImagePath ="banan1.jpg",
                    UnitPrice = 150000,
                    CategoryID = 1
                },
                new Book
                {
                    BookID = 3,
                    BookName = "Ghế",
                    Description = " Phong cách Châu Âu",
                    ImagePath ="ghe.jpg",
                    UnitPrice = 168000,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 4,
                    BookName = "Salong",
                    Description = "Salong hiện đại kiểu bắc mỹ",
                    ImagePath ="salong.jpg",
                    UnitPrice = 210000,
                    CategoryID = 2
                },            
            };
            return books;
        }
    }
}