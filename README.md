# MusacaWebApp
MUSACA (Multi-User Selling and Accounting Cashier Application) form @SoftUni web basic course
1. 1.Technological Requirements

- Use the **SIS.WebServer**
- Use the **SIS.MvcFramework**
- Use **Entity**** Framework ****Core**

1. 1.Database Requirements

The **Database** of the **MUSACA** application needs to support **3 entities** :

### User

- **Id** - a **GUID**** String, Primary Key**

- **Username**  **-****  a **** string **with** min length ****5** and **max length 20** ( **required** )
- **Email**** - ****a**  **string** with **min length**** 5 **and** max length 20**(**required**)
- **Password**** - ****a**  **string – hashed**  **in the database** ( **required** )

### Product

- **Id** - a **GUID**** String ****, Primary Key**

- **Name** - **a**  **string** with **min length**** 3 **and** max length 10**(**required**)
- **Price** – a **decimal** with **min**** value **–** 0.01**.

### Order

- **Id** – a **GUID**** String **or an** Integer**
- **Status** – can be one of the following values (&quot; **Active**&quot;, &quot; **Completed**&quot;)
- **Issued On**  **– a**  **Date**  **object.**
- **Products** – a collection of **Product** objects
- **CashierId** – a **GUID foreign key (required)**
- **Cashier** – a **User** object

1. 2.Functional Requirements

The functionality of the **MUSACA** application is quite simple. The Users are the Cashiers, and they are &quot;checking out products&quot; literally.

### Main functionality

When a **User** logs in, he sees several things on his **Index page**.

- A form for **ordering** a **Product** by **name**.
- A list of the **Products** for the current **Order**.
  - With **Product**** Mame **,** Product ****Price**
- A [**Cashout**] button which completes the **Order**.

### Products

The **Products** are just **data**** entities **. They are** only ****created** and **persisted**. The **Orders** do not affect them in any way. The **Products** are like **templates** , so that the **User** knows what he is ordering.

### Orders

For each **User** , there is **exactly 1 Active**** Order** at all time.

By entering a **name** of an existent **Product** , in the **form** on the **top** of the **Index page** , a **User** adds a **Product** to his currently **Active**** Order **. Upon completing this functionality, the application should** redirect **back to the** Index page **, where the** User**(Cashier) can see his**Order **and the** Products**.

An **Order** is created with **status** – &quot; **Active**&quot; by **default**. The currently **Active**** Order **is visualized on the** Index page **as a list of its** Products **, with their** Product **&#39;s** Name **and their** Product **&#39;s** price **. A** Total ****Price** is also visualized, below the list, which is a sum of every **Product**&#39;s **Price**.

**NOTE** : Only the currently **Active**** Orders**(with**status **– &quot;** Active**&quot;) is visualized on the**Index page**.

Clicking the [**Cashout**] button on the bottom of the **Index**** page **should** change **the currently** Active Order **&#39;s status to &quot;** Completed**&quot;.

Another **Order** should be **created** with the **currently logged-in**** User **as** Cashier **and it should become the current** Active ****Order**.

**NOTE** : Upon **Registering** a **User** , you should create the initial **Active**** Order** for it.

### Users

All **Users** can **View**** All ****Products** , **Create**** Products **,** Cashout **and** View ****All**** Personal ****Orders**.

Each **User** can check data about all the **Products** , by clicking on the [**Products**] button from the **navbar**. This should **redirect** him to the **Products All page**.

Each **User** can check data about all **HIS Completed**** Orders**, by clicking on the [**{Username}**] button from the**navbar **. This should redirect him to the** Profile page **. On that page, the** User **can check a list of only** HIS ****Orders** , and only the **Completed** ones (status = &quot; **Completed**&quot;).

Each **User** can also create new **Products** , by clicking on the [**Create Product**] button from the **navbar**. This should redirect him to the **Product Create page**. **NOTE** : Creating a **Product** , should **redirect** to the **Products All**.

**NOTE** : All decimal data is visualized up to the **second digit** after the decimal point.

1. 3.Security Requirements

The **Security Requirements** are mainly access requirements. Configurations about which users can access specific functionalities and pages.

- **Guest** (not logged in) users can access **Index** page and functionality.
- **Guest** (not logged in) users can access **Login** page and functionality.
- **Guest** (not logged in) users can access **Register** page and functionality.
- **Users** (logged in) can access **User**** LoggedIn ****Index** page and functionality.
- **Users** (logged in) can access the **Product**** Create** page and functionality.
- **Users** (logged in) can access **Products** page and functionality.
- **Users** (logged in) can access **Order** functionality.
- **Users** (logged in) can access **User**** Profile** page and functionality.
- **Users** (logged in) can access **Logout** functionality.

1. 4.Code Quality

Make sure you provide the best architecture possible. Structure your code into different classes, follow the principles of high-quality code. You will be scored for the **Code**** Quality **and** Architecture** of your project.

1. 5.Data Validation

- In case of invalid data during the **login** , redirect to &quot; **Users/Login**&quot;
- In case of invalid data during the **registration** , redirect to &quot; **Users/Register**&quot;
- In case of invalid data during the **product creation** , redirect to &quot; **Product**** /Create**&quot;
