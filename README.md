# GUI-DOS
Online Gift-Basket ordering system.

## Setting up the server
The first time running the server the following should be in `Areas/Identity/Pages/Account/Register.cshtml.cs`.

```
/* [Authorize] */
[AllowAnonymous]
```

and

```
var identityResult = await _roleManager.CreateAsync(new IdentityRole("superuser"));
if (identityResult.Succeeded)
    await _userManager.AddToRoleAsync(user, "superuser");
```

Then run the server and navigate to `/admin/register` and create a user. This will create a user that has the "superuser" role which has the option to delete other users. Once you have created your superuser, you will want to toggle the comments seen in the previous snippets. The system will now be good to go.

## Packages
|Package     |.NET CLI.                          |
|------------|-----------------------------------|
|FsCheck|dotnet add package FsCheck --version 2.16.3|
|FsCheck.Xunit|dotnet add package FsCheck.Xunit --version 2.16.3      |
|MailKit|dotnet add package MailKit --version 2.15.0|
|Blazored Modal|dotnet add package Blazored.Modal|
|MudBlazor|dotnet add package MudBlazor --version 5.2.0|

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
