11/19/2023

part 1 of assignment 2
START ALL OVER AGAIN and making sure i do not miss a thing 
i debued if to make sure the program work 
add the bootwatch to the program 
removing the dark text and aslo add the text-white the site 
there was probrlm it was hte bootwatch does not want to work but i forgot to change in the layout to bootstrap.min.css to bootstrap.css
i haved add the link that you have proved for the link in layout (css/scrpiti)
i have create a dropdown list in layout 
i have add new project called AbdulBooks.DataAccess,AbdulBooks.Models,and AbdulBooks.Utility and also moved the data file to DATAACCESS
i have downlaod the Core.Sqlserverand also the relatinal pages and than deltet the migrations folder 
i have add all the Nutget Package
i have deleted all of the class 1 files 
i have moved the model folder and also add the models  and renamed it to viewModel
namespace AbdulBookStore.Models changed to namespace AbdulBookStore.Models.viewmodels
i have add using AbdulBookStore.DataAccess.Data; to startup and delet the data one 
i ran the program and it works very well
create a new class in Uitity called SD.CS 
ADDED THE PROJECT REFFENCE TO ABDULBOOTSTORE 
i have changed the route of the pattern ot {area=customer}
move the homecontorller to cuosmter and deteled data and models folder

changed the namespace in homecontoller to namespace AbdulBookStore.Area.Customer.Controllers and add [Area("Customer")]
i have add the home folder to view and put in viewimport,viewstart
there is probelm is said there was  a mistake in viewstart
mispelled the view should havve benn views 
i add viewimports and viewstart in the admin view folder and also removed the homecontoler from controller

11/20/2023
i removed some code in asppsettings 
i have add this 20231120162542_addDefaultIdentityMigration to migrationd folder 
i have add new .cs in Models and add a new table 
there was a problem which was the add-migration AddCategoryToDb does not work
i forgot to switch the the defualt project to dataAccess
i code this "public DbSet<Category>Categories { get; set; }" in the applicationDbContext.cs
i have deleted  addCategory and add a new one category 
add new folder called reposity and Ireposity 
add class in respoity for intface class 
in that class i add remove and add from Get item in Db 
i add new class in Repository and coded to create constructors and dependency 
i used the file that you have proved for us to use which i have done 
i have made connection to category and icatogroy 
there is red line under ICategoryRepository in cateogryReposirty 
i fix the problem which was a spelling mistake of catefory 
i have add a ISP_CALL.CS in IRespoirty  for interface and also download DAPPER Nutpage
add new class called SP_Call in Repository and i have connectioned to the database  with this class 
i have edited SP_Call for it work 
add a interface in IRepository  and also update the code 
added the IUnitOfWork interface to IRepository
added the  UnitOfWork class in Repository 
update in UnitOfWork
 "public void Dispose()
        {
            _db.Dispose();
        }
         public void save()
        {
            _db.SaveChanges();
        }"

   
   there was a problem my Category does not work beucase it does not say on uniofWork
   find the problem in Unofwork Category was with small c and now is fix 


   11/21/2023

now i am stater on part 3 1 silde
created a cover type Crued with id and name 
add covertype to the respoisprty by adding class, interface,unitofwork,iunofwork, database
performed CRUD  operations on cover type 
-add nav bar
-covertpye contoller
-index view
-updsert view
-delete covertype 
made new class in .models called Prodcut
i have add the code that you have proveid to us 
added "public DbSet<Product> Products { get; set;} " to ApplictionDbContext.cs 
"add-migration addProductToDb" in the program and it worked 9:36Am

 i have made   [Required] to Title,ISBN,Author
 addValidationToProduct add to commend line and also ot worked 
 and now have connneted the product to iUnitOFwork and unitofwork and also add the code i need for 
 i have add a Prodcutcontoller to contoller file and type the code 
 after i finshed the prodecontoller i have made a new cs in viewmodel called product and used the code 
 i have modfiy the ProductContoller 
 added a new link in layout and also made a file for prodect for it and aslo that was prodvied 
 i have started phase 3 and which by add a product file and what it needs 
 problem in upsert in the using name
 i have fix the probelm by uing viewmodels


 Aissgnment 2 part -IV

 5:40PM 11/23/2023

 5:48PM  i have add price, price50 and also price100 to Products.cs in Models.
 5:57PM i have openedup SD.cs which was Utility folder and add this 
        public const string Proc_CoverType_Create = "usp_CreateCoverType";
        public const string Proc_CoverType_Get = "usp_GetCoverType";
        public const string Proc_CoverTyp_GetAll = "usp_GetCoverType";
        public const string Proc_CoverTyp__Update = "usp_UpdateCoverType";
        public const string Proc_CoverTyp_Delete = "usp_DeleteCoverType";

6:09  i have adjuted the ProductController for an updsert to make add images path for it to accuess 
6:34 i have add new update list in upsert in Prduct folder(Price50)
6:41 styling the list Upsert images url
6:45 changes view(by add a list) things in Index in Product folder 

11/24/2023
1:44PM i have commeted out   /*_db.SaveChanges();*/ in Resposiotry folders ONLY
11:53 i have comment out the for covertype and productReposroty because it was extria and add prduct in UnitOfWork
1:56 there was an error in CoverType but now is fixed becuase now i have changed the IReposirtoty 
2:06 changed the postion for    [Required] in covertype in viewModels 
2:12 i have changed few thing in covertype contoller which is for add id  
2:17 error some how covertype is no in SD 
2:18 there was a miss type on sd so on covertypeupdate did not work but now is fix 