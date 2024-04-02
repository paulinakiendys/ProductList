# ProductList

## Introduction
This console application allows users to manage a list of products. Users can add new products, search for products, list all products, and exit the application.

## How to Use
1. When prompted, choose one of the following options:
   - **P**: Add a new product.
   - **S**: Search for a product.
   - **L**: List all products.
   - **Q**: Quit the application.
2. Follow the prompts to add a new product or search for a product.
3. If you choose to list all products, they will be displayed sorted by price, with the total amount at the bottom.

## Features
- **Add Product**: Users can add a new product by providing the category, product name, and price.
- **Search Product**: Users can search for a product by its name.
- **List Products**: Users can view all products sorted by price, with the total amount at the bottom.
- **Error Handling**: The application handles errors gracefully and displays error messages when necessary.
- **LINQ Integration**: LINQ is used to sort products by price.
- **Search Highlighting**: When searching for a product, the matching product is highlighted in the list.

## Classes
The application is built using two classes:
1. **Product**: Represents a single product with properties for category, name, and price.
2. **ProductManager**: Manages the list of products and provides methods for adding products, searching products, listing products, and more.

## How to Run
To run the application, simply compile and execute the provided C# code using a compatible compiler or integrated development environment (IDE) such as Visual Studio.
