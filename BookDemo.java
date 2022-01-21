package apps;

import java.util.Scanner;

import book.utility.Book;
import book.utility.Ebook;
import book.utility.Paperbook;

public class BookDemo {
	public static void main(String[]args)
	{
		
		char type;
		String title;
		int id;
		double price;
		char e='e';
		Scanner sc= new Scanner(System.in);
		
		Book[]bk;
		bk=new Book[5];
		for(int i=0; i<bk.length;i++)
		{
		System.out.println("Enter the type of Book(e/p)");
		type=sc.next().charAt(0);
		
		System.out.println("Enter the book id:");
		id=sc.nextInt();
		System.out.println("Enter the book title:");
		title=sc.next();
		
		System.out.println("Enter the price:");
		price=sc.nextDouble();
		
		if(type=='e')
		{
			bk[i]= new Ebook(id, title, price);
			
		}
		else
		{ bk[i]=new Paperbook(id, title, price);
		
		}
		bk[i].display();
		System.out.println(bk[i].CalCost());
		}
	}
}
