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
   
   
   **Opcional:**
 
   `category=[string]`
   `description=[string]`
   `image=[string]`
   `nStars=[integer]`
   `idRestaurant=[integer]`
   `allergens=[string]`
   `mainIngredients=[string]`
   `nutritionalValue=[string]`

* **Resposta de sucesso:**

  * **StatusCode:** 200 <br />
    **Message:** `{ "Produto inserido com sucesso" }`
 
* **Resposta de erro:**

  * **StatusCode:** 404 <br />
    **Message:** `{ motivo do erro }`

  OU

  * **StatusCode:** 404 <br />
    **Message:** `{ "Produto inserido sem sucesso" }`
    
    
    
    
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
   
   
   **Opcional:**
 
   `image=[string]`
   `nStars=[integer]`
   `allCategories=[string]`
   `cheapPriceProduct=[integer]`
   `distanceUserAddress=[integer]`
   `description=[string]`

* **Resposta de sucesso:**

  * **StatusCode:** 200 <br />
    **Message:** `{ "Restaurante inserido com sucesso" }`
 
* **Resposta de erro:**

  * **StatusCode:** 404 <br />
    **Message:** `{ motivo do erro }`

  OU

  * **StatusCode:** 404 <br />
    **Message:** `{ "Restaurante inserido sem sucesso" }`
