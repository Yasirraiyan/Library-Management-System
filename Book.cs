    public class Book
    {
        public int id;
        public string title;
        public string author;
        public long ISBN;
        public int pagecount;
        public List<Book> books;
        public bool correct = false;
        public int[] capacity = [10, 20, 25, 67, 80];
        public int store = 0;
        public bool valid=false;

        public Book(int id, string title, string author, long iSBN, int pagecount)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.pagecount = pagecount;

        }
        public void addbook(Book b)
        {
            books.Add(b);
            Console.WriteLine($"The added book is:{b}");
            foreach (Book book in books)
            {
                Console.WriteLine($"The list of book is:{book}");
            }
        }
        public void removebook(Book b)
        {
            books.Remove(b);
            Console.WriteLine($"The removed book is:{b}");
            foreach (Book book in books)
            {
                Console.WriteLine($"The list of book is:{book}");
            }
        }
        public string searchbytitle(string title)
        {
            Console.WriteLine($"The title of the book is:{title}");
            return title;
        }
        public long searchbyISBN(long ISBN)
        {
            Console.WriteLine($"The ISBN of the book is:{ISBN}");
            return ISBN;
        }
        public string getauthor(string author)
        {
            Console.WriteLine($"The author of the book is:{author}");
            return author;
        }
        public void showbook()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"Books are:{book}");
            }
        }
        public (bool, long) checkISBN(long ISBN)
        {
            if ((ISBN > 999999999 && ISBN < 10000000000) || (ISBN > 999999999999 && ISBN < 10000000000000))
            {
                Console.WriteLine($"The ISBN is valid.The ISBN number is:{ISBN}");
                correct = true;
            }
            else
            {
                Console.WriteLine($"The ISBN is invalid!");
                correct = false;
            }
            return (correct, ISBN);
        }
        public long getprefixelement(long ISBN)
        {

            if (ISBN > 999999999999 && ISBN < 10000000000000)
            {
                correct = true;
                Console.WriteLine("The ISBN is valid");
            }
            long prefix = ISBN % 1000;
            Console.WriteLine($"The prefix is:{prefix}");
            return prefix;
        }
        public long getregistraiongroup(long ISBN)
        {
            if (ISBN > 999999999999 && ISBN < 10000000000000)
            {
                correct = true;
                Console.WriteLine("The ISBN is valid");
            }
            long registrationgrp = (ISBN % 1000) / 1000;
            Console.WriteLine($"The registration group is:{registrationgrp}");
            return registrationgrp;
        }
        public long getregistration(long ISBN)
        {
            if (ISBN > 999999999999 && ISBN < 10000000000000)
            {
                correct = true;
                Console.WriteLine("The ISBN is valid");
            }
            long registration = (ISBN % 1000) % 1000;
            Console.WriteLine($"The registration number is:{registration}");
            return registration;
        }
        public long getpublication(long ISBN)
        {
            if (ISBN > 999999999999 && ISBN < 10000000000000)
            {
                correct = true;
                Console.WriteLine("The ISBN is valid");
            }
            long publication = ((ISBN % 1000) % 1000) / 10;
            Console.WriteLine($"The publiction number is:{publication}");
            return publication;
        }
        public long getchecksum(long ISBN)
        {
            if (ISBN > 999999999999 && ISBN < 10000000000000)
            {
                correct = true;
                Console.WriteLine("The ISBN is valid");
            }
            long checksum = ((ISBN % 1000) % 1000) / 1000;
            Console.WriteLine($"The checksum number is:{checksum}");
            return checksum;
        }
        public long getgroupidentifier(long ISBN)
        {
            if (ISBN > 999999999 && ISBN < 10000000000)
            {
                Console.WriteLine("This ISBN is for group identifier");
            }
            long groupidentifier = ISBN % 100;
            Console.WriteLine($"The group identifier is:{groupidentifier}");
            return groupidentifier;
        }
        public long getpublisher(long ISBN)
        {
            if (ISBN > 999999999 && ISBN < 10000000000)
            {
                Console.WriteLine("This ISBN is for publisher");
            }
            long publisher = (ISBN % 100) / 100;
            Console.WriteLine($"The publisher is:{publisher}");
            return publisher;
        }
        public long getttitle(long ISBN)
        {
            if (ISBN > 999999999 && ISBN < 10000000000)
            {
                Console.WriteLine("This ISBN is for title");
            }
            long title = ((ISBN % 100) % 100) / 10;
            Console.WriteLine($"The title is:{title}");
            return title;
        }
        public long getchecksum2(long ISBN)
        {
            if (ISBN > 999999999 && ISBN < 10000000000)
            {
                Console.WriteLine("This ISBN is for checksum");
            }
            long checksum2 = ((ISBN % 10) % 10) / 10;
            Console.WriteLine($"The checksum is:{checksum2}");
            return checksum2;
        }
        public long getchecksumvalue(long ISBN)
        {
            long checksumvalue = ISBN % 10;
            Console.WriteLine($"The checksum value is:{checksumvalue}");
            return checksumvalue;
        }
        public Book searchBookById(int id)
        {
            Book foundBook = null;

            foreach (Book book in books)
            {
                if (book.id == id)
                {
                    foundBook = book;
                    break;
                }
                else if (book.id > id)
                {
                    Console.WriteLine("The book ID is greater than the search ID.");
                }
                else if (book.id < id)
                {
                    Console.WriteLine("The book ID is less than the search ID.");
                }
                else
                {
                    Console.WriteLine("Checking next book...");
                }
            }

            if (foundBook != null)
            {
                Console.WriteLine($"Book found: {foundBook}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }

            return foundBook;
        }
        public Book searchBookByPageCount(int pageCount)
        {
            Book foundBook = null;

            foreach (Book book in books)
            {
                if (book.pagecount == pageCount)
                {
                    foundBook = book;
                    break;
                }
                else if (book.pagecount > pageCount)
                {
                    Console.WriteLine("The book's page count is greater than the search page count.");
                }
                else if (book.pagecount < pageCount)
                {
                    Console.WriteLine("The book's page count is less than the search page count.");
                }
                else
                {
                    Console.WriteLine("Checking next book...");
                }
            }

            if (foundBook != null)
            {
                Console.WriteLine($"Book found: {foundBook}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }

            return foundBook;
        }
        public void showcapacity(int capacity)
        {
            for (int i = 0; i < capacity; i++)
            {
                Console.WriteLine(i);
                store += i;
                Console.WriteLine($"The value os stor is:{store}");
            }
            
        }
        public int getoddposition(int capacity)
        {
            int i;
            for ( i = 0; i < capacity; i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine($"The odd position is:{i}");
                }
            }
            return i;
        }
        public int getevenposition(int capacity)
        {
            int i;
            for (i = 0; i < capacity; i++)
            {
                if (i % 2 == 0)
                {
                    i = i * 3;
                    Console.WriteLine($"The even position is:{i}");
                }
            }
            return i;
        }
        public int  getlastdigitofchecksum(int capacity)
        {
            int i;
            int sum = 0;
            for(i=0;i<capacity;i++)
            {
                sum += i;
                Console.WriteLine("The last digit of checksum is:{sum}");
            }
            return sum;
        }
        public (bool,long) checkvalidityofchecksum(long ISBN)
        {
            if ((ISBN > 999999999 && ISBN < 10000000000) || (ISBN > 999999999999 && ISBN < 10000000000000))
            {
                Console.WriteLine($"The ISBN is valid.The ISBN number is:{ISBN}");
                valid = true;
            }
            else
            {
                Console.WriteLine($"The ISBN is invalid!");
                valid = false;
            }
            return (valid,ISBN);
        }
    }
}

