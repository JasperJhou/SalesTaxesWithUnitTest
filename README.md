# Console App Demo: SalesTaxes with Unit Test
(.NET Framework 4.7.1)

## Scenario

There are a variety of items for sale at a store. When a customer purchases items, they receive a receipt. The
receipt lists all of the items purchased, the sales price of each item (with taxes included), the total sales taxes for
all items, and the total sales price.

Basic sales tax applies to all items at a rate of 10% of the item’s list price, with the exception of books, food, and
medical products, which are exempt from basic sales tax. An import duty (import tax) applies to all imported items
at a rate of 5% of the shelf price, with no exceptions.

Write an application that takes input for shopping baskets and returns receipts in the format shown below,
calculating all taxes and totals correctly. When calculating prices plus tax, round the total up to the nearest 5
cents. For example, if a taxable item costs $5.60, an exact 10% tax would be $0.56, and the final price after adding
the rounded tax of $0.60 should be $6.20. 

## Input 1: 
  *	1 Imported bottle of perfume at 27.99 
  *	1 bottle of perfume at 18.99 
  *	1 packet of headache pills at 9.75 
  * 1 box of imported chocolates at 11.25  
  * 1 box of imported chocolates at 11.25

## Output 1: 
  *	Imported bottle of perfume: 32.19
  *	Bottle of perfume: 20.89
  *	Packet of headache pills: 9.75 
  *	Imported box of chocolates: 23.70 (2 @ 11.85)
  *	Sales Taxes: 7.30
  * Total: 86.53
  
## Design
  * SOLID principles
  * Unit Testing
  * Exception Handling
  * Code Extensibility (Ex: New SalesTax policy can be created by implemented ISalesTax)
  * Testability for each function
  * Allow custom input
  
## Assumptions
  * Input only one item each line (Ex: You can only scan one item at a time).
  * Classify proucts by using hardcode items (Ex: "chocolate bar", "chocolates", "headache pills") since we don't have database for mapping.
  * Food products only support item name contains "chocolate bar", "chocolates", "chocolate".
  * Medical products only support item name contain "headache" or "pills".
  * Books product only support item name contain "book".
  * Other products support item names except above.
  
  
  
  
