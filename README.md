# GUI-DOS
Online Gift-Basket ordering system.

## Packages
|Package     |.NET CLI.                          |
|------------|-----------------------------------|
|FsCheck     |dotnet add package FsCheck --version 2.16.3|
|MailKit     |dotnet add package MailKit --version 2.15.0|

## endpoints
- /shop
    - /basket
    - /purchase
    - /fill-in (email, number...)
    - /review  (order summary)
    - /cancel
- /admin
    - /product: all products
        - /insert
        - /edit/{id}: id of product that is being edited
        - /changelog{id}: -||-
    - /order: all orders
        - /change/{id}: id of order that we are changing
        - /changelog/{id}: id of order that we want to see changelog of
    - /employee: all employee
        - /register
        - /login
