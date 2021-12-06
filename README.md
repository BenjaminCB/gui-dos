# GUI-DOS
Repository for our gift-basket ordering and fulfilment system.

## Running the server
To run the server you will have have installed .NET 5.0. The newly released .NET 6.0 can not be used as we use features that are not yet supported on that version. To build and run simply run the following command within the gui-dos subdirectory.

`dotnet run`

## Setting up the server
### Creating an admin user
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

### Chosing font for webpages
In /mainLayout.razor under the shared folder, the shared layout and style is created. To change the font to calibri uncomment the code under "BrandTheme" by removing the "@* *@". To change the font, change "Calibri, sans-serif" to the desired font(s).
