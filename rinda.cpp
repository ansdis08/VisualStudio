#include<iostream>
#include<cstdlib>
using namespace std;

struct Node
{
	double data;
	Node *link;
};
//---------------------------
Node *CreateNode ()
{
Node *newNode; 		//1
newNode = new Node;	//2
cout<<"\nIevadiet skaitli, kuru pievienot:  ";
cin>>newNode->data;	//3
newNode->link=NULL;	//4
return newNode;		//5
}
//---------------------------

void PrintList (Node *head)
{ 
Node *cur;
cout<<"\nSaraksta elementi:\n";
cur=head;		//1
while (cur!=NULL)
      {cout<<cur->data<<" ";	//2
      cur=cur->link;        
      }
}

//----------------------------

Node *AddLast (Node *head) {
    Node *ped, *cur;
    if(!head) head=CreateNode();
    else {
        ped=CreateNode();
        cur=head;
        while (cur->link!=NULL)
            {cur=cur->link;}
        cur->link=ped;
        }
    return head;
}

//-------------------
Node *FindNode(Node *head,int x){
    Node *cur;
    cur=head;
    while(cur && cur->data!=x) cur=cur->link;
    return cur;
    }
//------------------

Node *FindNode2(Node *head,int x){
    Node *cur, *prev;
    cur=head;
    while(cur && cur->data!=x) {
        prev=cur;
        cur=cur->link;
        }
    return prev;
    }

//-----------------

Node *DeleteFirst (Node *head) {
    Node *cur;
    if(head)
        {
        cur=head->link;
        delete head;
        cout<<"\nIzdzests. \nNakamais kluva par head.";
        system("pause>nul");
        return cur;
        }
    else {cout<<"\nNav head"; system("pause>nul"); return NULL;}
    }
    
//-------------------
    
Node *DeleteLast (Node *head) {
    Node *cur, *prev;
    cur=head;
    if(!head) cout<<"\nVel nav head"; return 0;
    if (head->link==NULL) head=DeleteFirst(head); return head;
    
    while (cur->link!=NULL)
            {prev=cur; cur=cur->link; }
        prev->link=0;
        delete cur;
        cout<<"\nIzdzests.";
    
    return head;
        }
        
//------------------

void DeleteAfter (Node *head) {
    int x;
    Node *y, *cur; 
    cout<<"\nPec kura skaitla dzest: ";cin>>x; 
            y=FindNode(head,x); 
        if(y){
            if(y->link!=NULL) {
                cur=y->link;
                y->link=cur->link;
                delete cur;
                cout<<"\nIzdzests.";
                
                } 
            else {
                cout<<"\nNav ko dzest!";
            system("pause>nul");
            }
        }
        else cout<<"\nNav tada skaitla";
        system("pause>nul");
    }

//---------------------------

Node *DeleteBefore (Node *head){
    int x;
    Node *y, *cur, *prev;
    cout<<"\nPirms kura skaitla dzest: ";cin>>x;
    y=FindNode(head,x); //tekosais
    cur=FindNode2(head,x); //pirms ta
    if(cur!=head){
    prev=FindNode2(head,cur->data); //pirms pirms
    prev->link=y;
    delete cur;
    }
    else { delete head; 
            head=y;
            }
    cout<<"\nIzdzests.";
    return head;
    
    }



int main(){
Node *head=NULL,*newNode,*tresais,*nultais, *ped, *cur;
int darbiba,x;
do{
    system("cls");
    cout<<"Linearais saraksts\n";
    cout<<"\n1.Izveidot head";
    cout<<"\n2.Izvadit sarakstu";
    cout<<"\n3.Pievienot saraksta beigas";
    cout<<"\n4.Delete first";
    cout<<"\n5.Count Nodes";
    cout<<"\n6. Izdzest visu";
    cout<<"\n7.Pabeigt programmu";
    cout<<"\nIevadiet komandu:";
    cin>>darbiba;
    switch(darbiba){
        case 1: if(!head) head=CreateNode();
            else {
                cout<<"\nhead jau eksiste"; 
                system("pause>nul");
                } 
                break;
        case 2: PrintList(head); 
            system("pause>nul"); 
            break;
        case 3: head=AddLast(head);           
            break;
        case 4: head=DeleteFirst(head);
            break;
        case 5: {
                int nodeCount = CountNodes(head);
                cout << "\nSaraksta elementu skaits: " << nodeCount << endl;
                system("pause>nul");
                break;
            }
        case 6: DeleteAll(head);
                system("pause>nul");
                break;
        case 7: cout<<"Programmas beigas"; break;
        default: cout<<"Nepareizs ievads!";
        }
    }
while(darbiba!=8);
	

system("pause>nul");

return 0;

      }
