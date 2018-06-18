Using the attached DBFiles/AdventureWorks2008 mdf file, the objective is to design a HTTP API that exposes data from the adventure works database as.
You are free to use whatever frameworks and whatever design patterns/methodologies you wish to incorporate. 
HTTP API Requirements
1.	Expose a "product" endpoint, which maps to the "DimProduct" table in the database.
    a. "product" endpoint should have the ability to get a product by id, get a list of products, as well as create, update and delete products.

2.	Expose a "product-category" endpoint which maps to the "DimProductCategory" table in the database.
    a. "product-category" endpoint should have the ability to get a product-category by id, get a list of product categories and get a list of product subcategories for a product category.

3.	Expose a "product-subcategory" endpoint which maps to the "DimProductSubcategory" table in the database.
    a. "product-subcategory" should have the ability to get a product-subcategory by id, get a list of product subcategories and get a list of products for a product subcategory.

4.	Only authenticated users should be able to use your API. 
    a. For the purposes of this test, all API requests must contain the following key in the header to be authenticated/authorised: =saASFe982dq19Dskadj
    b. Any requests that do not contain this key should return an appropriate unauthorised response.

5.	Validation for creating and updating a product should be present.
    a. Do not rely on SQL exceptions!

6.	Unit testing of the application should be present.  100% code coverage is not required, however important areas should be unit tested to demonstrate your approach (for example, areas involving business logic).

