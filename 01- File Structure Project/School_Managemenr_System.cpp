#include <iostream>
#include <fstream>
#include<stdlib.h>
using namespace std;

//class for Staff

class Staff{

public:
  char id[3];
  char name[30];
  char Jop[30];
  char section[3];
  char Class[20];

};

// class of student

class student{
public:
    char id[3];
    char name[30];
    char age[10];
    char section[3];
    char Class[10];

};
//Clear Function
void Cls()
{
    system("cls");
}
//Title Function
void Title(string title)
{
  cout<<"\t\t------------------------------------------\n";
  cout <<"\t\t\t\t  "<<title<<"\n";
  cout<<"\t\t------------------------------------------\n";
}


/*===========================================Staff===================================*/
//insert new record
void Staff_write()
{
  Cls();
  Title("Insert - Staff");
  ofstream f;
  Staff s;
  int counter=0; //for count the num of record you insert
  f.open("Staff.txt" , ios::app);
  char c = 'y';
  while( c == 'y' )
    {
	      counter++;
          cout <<"Enter.\n\t";
	      cout <<"1.ID : ";   cin>>s.id;
	      cout <<"\t2.Name : "; cin>>s.name;
	      cout <<"\t3.Jop : "; cin>>s.Jop;
	      cout <<"\t4.Section No : ";cin>>s.section;
	      cout <<"\t5.Class Name : "; cin >> s.Class;
	      f.write((char*) &s , sizeof(s) );
	      cout <<"\nDo you want to insert anther Record ? (y/n).\n";
	      cout <<">>>"; cin >>c;
    }
  cout<<"\n\t( "<<counter<<" ) Record is inserted.\n";
  f.close();
}
// show record
void Staff_Read()
{
  Cls();
  Title("READ RECORD");
  ifstream f;
  Staff s;
  f.open("Staff.txt" , ios::in);
  int counter=0;
  cout<<"\nID\tName\tJop\tSec\tClass\n";
  cout<<"----------------------------------------------\n";
  while(f.read((char*)&s , sizeof(s)) )
    {
      counter++;
      cout<<s.id<<"\t"<<s.name<<"\t"<<s.Jop<<"\t"<<s.section<<"\t"<<s.Class<<"\n";
    }
  f.close();
    cout<<"\n\t( "<<counter<<" ) Record is Found.\n";
}
//update record
void Staff_Updata()
{
  Cls();
  Title("UPDATA RECORD");
  fstream f;
  Staff s;
  f.open("Staff.txt" , ios::in|ios::out);
  string  id;
  char ch;
  char c;
  bool flage=false;
  cout <<"Enter id : "; cin >>id;
  while( f.read((char*)&s , sizeof(s) ) )
    {

      if ( id  == s.id )
	{
	  cout<<"\nThis Record You want Updata.\n";
	  cout<<"\nID\tName\tJop\tSec\tClass\n";
  	  cout<<"----------------------------------------------\n";
	  cout<<s.id<<"\t"<<s.name<<"\t"<<s.Jop<<"\t"<<s.section<<"\t"<<s.Class<<"\n";
	  cout<<"----------------------------------------------\n";
	  flage=true;
	  do{
	  int k=f.tellg();
	  f.seekp(k-sizeof(s) , ios::beg);

	  cout <<"Choose Process.\n";
	  cout<<"------------------\n";
	  cout <<"\nUpdata.\n";
	  cout <<"\n\t1.ID.\t2.Name.   \t3.Jop.\n\t4.Sec.\t5.Class.\t6.Exit.\n";
	  cout <<">>> "; cin >> ch;
	  switch(ch)
		    {
		    case '1':
		      cout <<"Enter New ID : "; cin >>s.id;
		      break;
		    case '2':
		      cout <<"Enter New Name : ";cin>>s.name;
		      break;
		    case '3':
		      cout <<"Enter New Jop :";cin>>s.Jop;
		      break;
		    case '4':
		      cout <<"Enter New Sec : "; cin >>s.section;
		      break;
		    case '5':
		      cout <<"Enter New Class : ";cin>>s.Class;
		      break;
		    default:
		      c ='n';
		      break;
		    }
	    f.write((char *) &s,sizeof(s) );

	    if( ch !='6'){
	    cout<<"Do You Want To Make additional updata ? (y/n).";cin>>c;}
	  }while(c!='n' && c!='N');//End do
	}//End of if
    }//End of While
  if(!flage)
    {
      cout <<"\nNo Record Found.\n";
    }
    f.close();
}//End of Function

void Staff_Delete()
{
  Cls();
  Title("Delete - Staff");
  Staff s;
  fstream f("Staff.txt" ,ios::in);
  ofstream t("Temp.txt" ,ios::out);
  string id ;
  int counter=0;
  bool flage=false;
  cout <<"Enter Staff's ID to Delete : ";cin>>id;
  while(f.read((char*)&s , sizeof(s) ))
    {

      if( id != s.id)
	{
	  t.write((char*)&s , sizeof(s) );
	}
      else
	{
	  counter++;
	  flage=true;
	}
    }
  f.close();
  t.close();
  if(flage)
    {
      remove("Staff.txt");
      rename("Temp.txt" ,"Staff.txt");
      cout<<"\n\t( "<<counter<<" ) Record is Deleted.\n";
    }
  else
    {
      cout<<"\nNo Record Found!\n";
    }
}

void Staff_Search()
{
  Cls();
  Title("SEARCH RECORD");
  Staff s;
  bool flage=false;
  ifstream f("Staff.txt",ios::in);
  string  id ;
  int  counter=0;
  cout <<"Enter Staff's ID You want Search: ";cin >>id;
  cout<<"\nID\tName\tJop\tSec\tClass\n";
  cout<<"----------------------------------------------\n";
  while( f.read((char*)&s , sizeof(s) ))
    {
      if(id == s.id)
	{
	  counter++;
	  flage=true;
	  cout<<s.id<<"\t"<<s.name<<"\t"<<s.Jop<<"\t"<<s.section<<"\t"<<s.Class<<"\n";
	}

    }
   if(!flage)
  {
	cout <<"\nNo Record Found.\n";
  }
	cout<<"\n\t( "<<counter<<" ) Record is Found.\n";

}

void Staff_Menu()
{
    char ch;
    char c;
    do{
      Cls();
      cout<<"\t================================================================\n";
      cout <<"\t\t  Staff ( 'ID' , 'Name' , 'Jop' ,'Sec' , ' Class' ) \n";
      cout<<"\t================================================================\n";
      cout <<"Choose Operation.\n";
      cout<<"-----------------------\n";
      cout <<"\t1.Insert.\t2.Read.  \t3.Search.\n\t4.Updata.\t5.Delete.\t6.Main Menue.\n";
      cout <<">>>"; cin >> ch;
      switch(ch)
	{
	case '1':
	  Staff_write();
	  break;
	case '2':
	  Staff_Read();
	  break;
	case '3':
	  Staff_Search();
	  break;
	case '4':
	  Staff_Updata();
	  break;
	case '5':
	  Staff_Delete();
	  break;
	case '6':
	 c='n';
	  break;
	default:
	  break;
	}
      if(ch !='6' ){
      cout <<"\n\nDo You Want Return To Menu ? (y/n)."; cin>>c;}
    }while(c!='n' &&c!='N');
}
/*===========================================Student=================================*/

void add_student(){
  Cls();
  Title("Insert - Student");
        student s;
        fstream f;
	int counter=0; // for count the num of record you insert
        f.open("student.txt",ios::app|ios::out);
	char c='y';
	while( c=='y' )
        {
	    counter++;
            cout <<"Enter.\n\t";
	    cout <<"1.ID : ";cin >>s.id;
	    cout<<"\t2.Name : "; cin>>s.name;
            cout<<"\t3.Age : "; cin>>s.age;
            cout<<"\t4.Section No : "; cin>>s.section;
            cout<<"\t5.Class Name : "; cin>>s.Class;
            f.write((char*)&s,sizeof (s));
	    cout<<"\nDo You Want Add another Record ? (y/n)\n";
	    cout <<">>>"; cin >>c;
        }
        f.close();
	cout<<"\n\t( "<<counter<<" ) Record is inserted.\n";
}

void search_student()
{
  Cls();
  Title("  Search - Student");
    student s;
    int counter=0;
    string name_sch;
    cout<<"Enter Student Name You Want Search : ";
    cin>>name_sch;
    fstream file;
    file.open("student.txt",ios::in);
    cout<<"\nID\tName\tAge\tSec\tClass\n";
    cout <<"-----------------------------------\n";
    while (file.read((char*)&s,sizeof(s)) )
    {
        if (name_sch == s.name)
            {
		counter++;
                cout<<s.id<<"\t"<<s.name<<"\t"<<s.age<<"\t"<<s.section<<"\t"<<s.Class<<"\n";
            }
    }
    file.close();
    cout <<"\n ( "<<counter<<" ) Record is Found With Name ( "<<name_sch<<" )\n";
}
void display(){
  Cls();
  Title("Display - Student");
    student s;
    int counter=0;
    fstream file;
    file.open("student.txt",ios::in);
    cout<<"\nID\tName\tAge\tSec\tClass\n";
    cout <<"-------------------------------------\n";
    while(file.read((char*)&s,sizeof(s)))
    {
	counter++;
        cout<<s.id<<"\t"<<s.name<<"\t"<<s.age<<"\t"<<s.section<<"\t"<<s.Class<<"\n";
    }
    file.close();
    cout <<"\n ( "<<counter<<" ) Record is Found.\n";
}
void delete_student()
{
  Cls();
  Title("Delete - Student");
    string name_;
    bool found=false;
    student s;
    fstream file1;
    fstream file2;
    file1.open("student.txt",ios::in);
    file2.open("temp.txt",ios::out);
    cout<<"Enter  the name of student to delete : ";
    cin>>name_;
    while (file1.read((char*)&s,sizeof(s)))
    {
        if ( name_ != s.name)
        {
            file2.write((char*)&s,sizeof(s));

        }
	else
	{
	    found=true;
	}

    }
    file1.close();
    file2.close();
    if(found)
    {
    	remove("student.txt");
        rename("temp.txt","student.txt");
	cout <<"\nRecord is Deleted.\n";
    }
    else
    {
        cout<<"\nNo Record Found with Name ( "<<name_<<" ) .\n";
    }
}
void updata_student()
{
  Cls();
  Title("UPDATA RECORD0");
  fstream f;
  student s;
  f.open("student.txt" , ios::in|ios::out);
  char ch;
  char c ;
  string  name;
  bool flage=false;
  cout <<"Enter Student Name : "; cin >>name;
  while(f.read((char*)&s , sizeof(s) ))
    {

      if ( name  == s.name )
	{
	  cout<<"\nThis Record You want Updata.\n";
	  cout<<"\nID\tName\tAge\tSec\tClass\n";
  	  cout<<"----------------------------------------------\n";
	  cout<<s.id<<"\t"<<s.name<<"\t"<<s.age<<"\t"<<s.section<<"\t"<<s.Class<<"\n";
	  cout<<"----------------------------------------------\n";
	  flage=true;
	  do{
	  int k=f.tellg();
	  f.seekp(k-sizeof(s) , ios::beg);
	  cout <<"Choose Process.\n";
	  cout<<"------------------\n";
	  cout <<"\nUpdata.\n";
	  cout <<"\n\t1.ID.\t2.Name.   \t3.Age.\n\t4.Sec.\t5.Class.\t6.Exit.\n";
	  cout <<">>> "; cin >> ch;
	  switch(ch)
		    {
		    case '1':
		      cout <<"Enter New ID : "; cin >>s.id;
		      break;
		    case '2':
		      cout <<"Enter New Name : ";cin>>s.name;
		      break;
		    case '3':
		      cout <<"Enter New Age :";cin>>s.age;
		      break;
		    case '4':
		      cout <<"Enter New Sec : "; cin >>s.section;
		      break;
		    case '5':
		      cout <<"Enter New Class : ";cin>>s.Class;
		      break;
		    default:
		     c='n';
		      break;
		    }
	    f.write((char *) &s,sizeof(s) );
	    if ( c !='n'  ){
	    cout<<"Do You Want To Make additional updata ? (y/n).";cin>>c;}
	  }while(c!='n' && c!='N');
	}
    }
  if(!flage)
    {
      cout <<"\nNo Record Found.\n";
    }
    f.close();
}//End of Function
void Student_Menu()
{
    char ch;
    char c;
    do{
      Cls();
      cout<<"\t================================================================\n";
      cout <<"\t\t  Student ('ID' , 'Name' , 'Age' , 'Section' ,'Class' ) \n";
      cout<<"\t================================================================\n";
      cout <<"Choose Operation.\n";
      cout<<"-----------------------\n";
      cout <<"\t1.Insert.\t2.Read.  \t3.Search.\n\t4.Updata.\t5.Delete.\t6.Main Menue.\n";
      cout <<">>>"; cin >> ch;
      switch(ch)
	{
	case '1':
	  add_student();
	  break;
	case '2':
	  display();
	  break;
	case '3':
	  search_student();
	  break;
	case '4':
	  updata_student();
	  break;
	case '5':
	  delete_student();
	  break;
	case '6':
	c = 'n';
	break;
	default:
	    cout <<"\nInvaild Choose Try Again !\n";
	  break;
	}
      if( ch != '6' ){
      cout <<"\n\nDo You Want Return To Menu ? (y/n)."; cin>>c;}
    }while(c!='n' &&c!='N');
}
void Search(char ch)
{
    string id ;
    int  counter=0;
    string name , jop , Class;
    Staff s;
    bool flage=false;
    student t;
    ifstream f1,f2;
    f1.open("Staff.txt" , ios::in );
    f2.open("student.txt" , ios::in );
    if( ch == '1' )
    {
	    cout <<"Enter ID You Want Group by : ";
	    cin >> id ;
    }
    else if( ch == '2' )
    {
	    cout <<"Enter Name You Want Group by : ";
	    cin >> name ;
    }
    else if( ch == '3' )
    {
	    cout <<"Enter Jop You Want Group by : ";
	    cin >> jop ;
    }
    else
    {
	    cout <<"Enter Class Name You Want Group by : ";
	    cin >> Class ;
    }
    cout<<"\nID\tName\tJop\tAge\tSec\tClass\n";
    cout<<"----------------------------------------------\n";

    while( f1.read((char*)&s , sizeof(s) ))
    {
	if( ch == '1' )
	{
	      if(id == s.id)
		{
		  counter++;
		  flage=true;
		  cout<<s.id<<"\t"<<s.name<<"\t"<<s.Jop<<"\t"<<"-\t"<<s.section<<"\t"<<s.Class<<"\n";
		}
	}
	else if (ch == '2' )
	{
		if(name == s.name)
		{
		  counter++;
		  flage=true;
		  cout<<s.id<<"\t"<<s.name<<"\t"<<s.Jop<<"\t"<<"-\t"<<s.section<<"\t"<<s.Class<<"\n";
		}
	}
	else if (ch == '3' )
	{
		if( jop == "student" ) break;
		if(jop == s.Jop)
		{
		  counter++;
		  flage=true;
		  cout<<s.id<<"\t"<<s.name<<"\t"<<s.Jop<<"\t"<<"-\t"<<s.section<<"\t"<<s.Class<<"\n";
		}
	}
	else
	{
		if(Class == s.Class)
		{
		  counter++;
		  flage=true;
		  cout<<s.id<<"\t"<<s.name<<"\t"<<s.Jop<<"\t"<<"-\t"<<s.section<<"\t"<<s.Class<<"\n";
		}
	}

    }
     while( f2.read((char*)&t , sizeof(t) ))
    {
      if( ch == '1' )
	{
	      if(id == t.id)
		{
		  counter++;
		  flage=true;
		  cout<<t.id<<"\t"<<t.name<<"\t"<<"Student"<<"\t"<<t.age<<"\t"<<t.section<<"\t"<<t.Class<<"\n";
		}
	}
	else if (ch == '2' )
	{
		if(name == t.name)
		{
		  counter++;
		  flage=true;
		  cout<<t.id<<"\t"<<t.name<<"\t"<<"Student"<<"\t"<<t.age<<"\t"<<t.section<<"\t"<<t.Class<<"\n";
		}
	}
	else if (ch == '3' )
	{
		if(jop == "student")
		{
		  counter++;
		  flage=true;
		  cout<<t.id<<"\t"<<t.name<<"\t"<<"Student"<<"\t"<<t.age<<"\t"<<t.section<<"\t"<<t.Class<<"\n";
		}
	}
	else
	{
		if(Class == t.Class)
		{
		  counter++;
		  flage=true;
		  cout<<t.id<<"\t"<<t.name<<"\t"<<"Student"<<"\t"<<t.age<<"\t"<<t.section<<"\t"<<t.Class<<"\n";
		}
	}

    }
   if(!flage)
  {
	cout <<"\nNo Record Found.\n";
  }
   cout <<"\n\t( "<<counter<<" ) Record is Found.\n";

}

void Quary()
{
      char ch;
      char c;
      do{
      Cls();
      cout<<"\t================================================================\n";
      cout <<"\t\t\t           Quary \n";
      cout<<"\t================================================================\n";
      cout <<"\nGet Quary From school DataBase.\n\n";
      cout <<"Group By.\n\t";
      cout <<"1.ID.\n\t2.Name.\n\t3.Jop\n\t4.Class\n\t5.Main Menu\n";
      cout <<">>>"; cin >>ch;
      if( ch == '1' || ch == '2' || ch == '3' || ch == '4' )
      Search(ch);
      else
	c = 'n';
     if( c != 'n' ){
      cout <<"\n\nDo You Want Return To Menu ? (y/n)."; cin>>c;}
    }while(c!='n' &&c!='N');

}


int main()
{
     char c;
    do{
	char ch;
	Cls();
	cout <<"\n\t=========================================================\n";
	cout <<"\t\t\tSCHOOL MANAGEMENT SYSTEM PROJECT\n";
	cout <<"\t==========================================================\n";
	cout <<"\n\n\nSelect.\n\n";
	cout <<"\t\t1.Staff\n\t\t2.Student.\n\t\t3.Quary.\n\t\t4.Exit\n";
	cout <<">>>"; cin >> ch;
	switch(ch)
	{
		case '1':
			Staff_Menu();
			break;
		case '2':
			Student_Menu();
			break;
		case '3':
			Quary();
			break;
		case '4':
			exit(0);
		default:
		    cout <<"\nInvaild Choose Try Again !\n";
			break;
	}

	cout<<"\nDo you Want To Back Main Menu ? (y/n) : "; cin >> c;
	}while(c !='n' && c!='N' );
}


