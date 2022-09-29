# API da app "Traz Cá"
**Criar produto**
----
  Insere dados de um produto em formato JSON. 
  
* **URL**

  /insertProduct

* **Método:**

  `POST`
  
*  **Parâmetros de URL**

   Nenhum

* **Parâmetros de dados**

  **Obrigatório:**
 
   `name=[string]`
   `price=[decimal]`
   `category=[string]`
   `idRestaurant=[integer]`
   
   
   **Opcional:**
 
   `description=[string]`
   `image=[string]`
   `nStars=[integer]`
   `allergens=[string]`
   `mainIngredients=[string]`
   `nutritionalValue=[string]`

* **Resposta de sucesso:**

  * **StatusCode:** 200 <br />
    **Message:** `{ "Produto criado com sucesso" }`
 
* **Resposta de erro:**

  * **StatusCode:** 404 <br />
    **Message:** `{ motivo do erro }`

  OU

  * **StatusCode:** 404 <br />
    **Message:** `{ "Produto criado sem sucesso" }`
    
    
    
    
**Criar restaurante**
----
  Insere dados de um restaurante em formato JSON. 
  
* **URL**

  /insertRestaurant

* **Método:**

  `POST`
  
*  **Parâmetros de URL**

   Nenhum

* **Parâmetros de dados**

  **Obrigatório:**
 
   `name=[string]`
   `address=[string]`
   
   
   **Opcional:**
 
   `image=[string]`
   `nStars=[integer]`
   `allCategories=[string]`
   `cheapPriceProduct=[integer]`
   `distanceUserAddress=[integer]`
   `description=[string]`

* **Resposta de sucesso:**

  * **StatusCode:** 200 <br />
    **Message:** `{ "Restaurante criado com sucesso" }`
 
* **Resposta de erro:**

  * **StatusCode:** 404 <br />
    **Message:** `{ motivo do erro }`

  OU

  * **StatusCode:** 404 <br />
    **Message:** `{ "Restaurante criado sem sucesso" }`
    
    
    
    
**Criar Utilizador**
----
  Insere dados de um utilizador em formato JSON. 
  
* **URL**

  /insertUser

* **Método:**

  `POST`
  
*  **Parâmetros de URL**

   Nenhum

* **Parâmetros de dados**

  **Obrigatório:**
 
   `name=[string]`
   `role=[string]`
   `address=[string]`
   `email=[string]`
   `password=[string]`
   `paypal=[string]`
   
   
   **Opcional:**
 
   `phoneNumber=[string]`

* **Resposta de sucesso:**

  * **StatusCode:** 200 <br />
    **Message:** `{ "Utilizador criado com sucesso" }`
 
* **Resposta de erro:**

  * **StatusCode:** 404 <br />
    **Message:** `{ motivo do erro }`

  OU

  * **StatusCode:** 404 <br />
    **Message:** `{ "Utilizador criado sem sucesso" }`
