The project was developed in VS Code. Please clone the source code and follow the instructions below to run and test it.

1. Go to cloned folder on your computer and type: <b>'code .'</b> to open VS Code
   
![image](https://github.com/user-attachments/assets/224c80e4-ac0e-482a-bf28-8c0e7bd2a661)

3. In opened VS code press Ctrl+` to open Terminal window and type following set of commands to build and run the project:
   
<b>
cd .\Backend\ </br>
cd .\Marktguru.WebAPI\ </br>
dotnet build </br>
dotnet run </br>
</b>
</br>

![image](https://github.com/user-attachments/assets/d83f0e86-6511-4573-8d86-87cc490f6883)

3. To be able to call WebAPI endpoints please open Postman (or install it if needed) and import prepared MarktGuru Postman Collection (which is part of this project and located in '<i>[Clone Folder]\Dev\Misc\MarktguruApp.Postman.json</i>'):

![image](https://github.com/user-attachments/assets/8604c2b7-cd55-4585-aa0a-8e0ca2cf5e31)

4. Run GetProductById endpoint (does not require anuthentication) to see if we have any results:

![image](https://github.com/user-attachments/assets/2301c0fc-1e95-46d5-b31f-3b1780c44923)

5. To run endpoints, which require authentication: go to Login endpoint and run it with the following credentials: 'userName: user1 and password: Password1' like on the picture below:

![image](https://github.com/user-attachments/assets/400fdc0a-b3be-4303-9b5f-c74ca4a4cde5)

As a result, you will get a Token which should be used in a Header for operations, which require authentication (otherwise you will get 401 - Unauthorized): AddProduct, UpdateProduct, DeleteProduct.

![image](https://github.com/user-attachments/assets/28157f2a-7f44-4800-8ae5-baa2ab7968ea)

6. Finally you can play with AddProduct, UpdateProduct, DeleteProduct operations:

![image](https://github.com/user-attachments/assets/b725e024-d3fb-4f06-9415-562d4bccd36d)

Thank you!
