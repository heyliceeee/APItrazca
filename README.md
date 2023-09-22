# API da app "Traz Cá"
## Produto

<details>
  <summary>Criar</summary>
  <pre> Criar um produto. </pre>

  **[POST]** `{{host}}/insertProduct`
  
**Body**
| Campo      | Tipo | Descrição                           | Obrigatório |
|:---------------|:----:|:------------------------------------|:-----------:|
| `name`     | string  | Nome do produto.         |     Sim     |  
| `price` | double  | Preço do produto. |     Sim     |             
| `category` | string  | Categoria do produto. |     Sim     |
| `idRestaurant` | integer  | ID do Restaurante do produto. |     Sim     |
| `description` | string  | Descrição do produto. |     Não     |
| `image` | string  | Imagem do produto. |     Não     |
| `nStars` | integer  | Número de estrelas do produto. |     Não     |
| `allergens` | string  | Alergénicos do produto. |     Não     |
| `mainIngredients` | string  | Ingredientes principais do produto. |     Não     |
| `nutritionalValue` | string  | Valor nutricional do produto. |     Não     |

```json
{
    "name": "Crispy Chicken",
    "price": 1.00,
    "category": "Hamburger",
    "idRestaurant": 1,
    "description": "Crocante por fora, suave por dentro. O melhor frango com um panado crocante, tomate acabado de cortar, alface fresca e maionese num pão de sementes acabado de torrar. Uma verdadeira obra de arte.",
    "image": "https://www.nit.pt/wp-content/uploads/2020/10/6f7b4074e48a10d14e8cd990c4b646e7-754x394.jpg",
    "nStars": 5,
    "allergens": "Glúten, Ovo, Aipo, Sésamo, Pode conter tremoços, Pode conter mostarda, Pode conter proteína de soja, Pode conter produtos lácteos, Pode conter SO2 e sulfitos",
    "mainIngredients": "Alface, Tomate, Maionese",
    "nutritionalValue": "Peso 189g, Calorias 516kcal, Proteínas 16.4g, Carboidratos 42.2g, Açúcar 6.3g, Açúcar adicionado 0.9g, Gorduras 30.5g, Gorduras monoinsaturadas 12g, Gorduras pollinsaturadas 13.3g, Gordura saturada 5.6g, Gordura trans hidrogenada 0g, Gordura trans natural 0.2g, Gordura trans 0.2g, Fibra 3.3g, Sódio 725mg, Sal 1812mg, Sal adicionado 1812mg"
}
```
**Response**

201 Created
```json
{
    "Produto criado com sucesso"
}
```
404 Error
```json
{
    "Produto criado sem sucesso"
}
```
</details>


## Pedido

<details>
  <summary>Criar</summary>
  <pre> Insere dados de um pedido em formato JSON. </pre>
  
* **URL**

  /insertOrder

* **Método:**

  `POST`
  
*  **Parâmetros de URL**

   Nenhum

* **Parâmetros de dados**

  **Obrigatório:**
 
   `timeUserAddress=[datetime]`
   `idCart=[integer]`

* **Resposta de sucesso:**

  * **StatusCode:** 200 <br />
    **Message:** `{ "Pedido criado com sucesso" }`
 
* **Resposta de erro:**

  * **StatusCode:** 404 <br />
    **Message:** `{ motivo do erro }`

  OU

  * **StatusCode:** 404 <br />
    **Message:** `{ "Pedido criado sem sucesso" }`
</details>


## Carrinho

<details>
  <summary>Criar</summary>
  <pre> Insere dados de um carrinho em formato JSON. </pre>
  
* **URL**

  /insertCart

* **Método:**

  `POST`
  
*  **Parâmetros de URL**

   Nenhum

* **Parâmetros de dados**

  **Obrigatório:**
 
   `subtotal=[decimal]`
   `deliveryFee=[decimal]`
   `discount=[decimal]`
   `total=[decimal]`
   `idUser=[integer]`

* **Resposta de sucesso:**

  * **StatusCode:** 200 <br />
    **Message:** `{ "Carrinho criado com sucesso" }`
 
* **Resposta de erro:**

  * **StatusCode:** 404 <br />
    **Message:** `{ motivo do erro }`

  OU

  * **StatusCode:** 404 <br />
    **Message:** `{ "Carrinho criado sem sucesso" }`
</details>

<details>
  <summary>Editar</summary>
  <pre> Edita dados de um carrinho em formato JSON. </pre>
  
* **URL**

  /editCart/{id}

* **Método:**

  `PUT`
  
*  **Parâmetros de URL**

   id

* **Parâmetros de dados**

  **Obrigatório:**
  
   `status=[string]`

  **Opcional:**
 
   `subtotal=[decimal]`
   `deliveryFee=[decimal]`
   `discount=[decimal]`
   `total=[decimal]`
   `idUser=[integer]`

* **Resposta de sucesso:**

  * **StatusCode:** 200 <br />
    **Message:** `{ "Dados do carrinho atualizados com sucesso" }`
 
* **Resposta de erro:**

  * **StatusCode:** 404 <br />
    **Message:** `{ motivo do erro }`

  OU

  * **StatusCode:** 404 <br />
    **Message:** `{ "Dados do carrinho atualizados sem sucesso" }`
</details>


## Item do Carrinho

<details>
  <summary>Criar</summary>
  <pre> Insere dados de um item do carrinho em formato JSON. </pre>
  
* **URL**

  /insertCartItem

* **Método:**

  `POST`
  
*  **Parâmetros de URL**

   Nenhum

* **Parâmetros de dados**

  **Obrigatório:**
 
   `quantity=[integer]`
   `idProduct=[integer]`
   `idCart=[integer]`
   
   
   **Opcional:**
 
   `noteProduct=[string]`

* **Resposta de sucesso:**

  * **StatusCode:** 200 <br />
    **Message:** `{ "Item do carrinho criado com sucesso" }`
 
* **Resposta de erro:**

  * **StatusCode:** 404 <br />
    **Message:** `{ motivo do erro }`

  OU

  * **StatusCode:** 404 <br />
    **Message:** `{ "Item do carrinho criado sem sucesso" }`
</details>


<details>
  <summary>Editar</summary>
  <pre> Edita dados de um item do carrinho em formato JSON. </pre>
  
* **URL**

  /editCartItem/{id}

* **Método:**

  `PUT`
  
*  **Parâmetros de URL**

   id

* **Parâmetros de dados**

  **Obrigatório:**
  
   `status=[string]`

  **Opcional:**
 
   `idCart=[integer]`
   `idProduct=[integer]`
   `quantity=[integer]`
   `noteProduct=[string]`

* **Resposta de sucesso:**

  * **StatusCode:** 200 <br />
    **Message:** `{ "Dados do item do carrinho atualizados com sucesso" }`
 
* **Resposta de erro:**

  * **StatusCode:** 404 <br />
    **Message:** `{ motivo do erro }`

  OU

  * **StatusCode:** 404 <br />
    **Message:** `{ "Dados do item do carrinho atualizados sem sucesso" }`
</details>


## Comentário acerca do Produto

<details>
  <summary>Criar</summary>
  <pre> Insere dados de um comentário acerca de um produto em formato JSON. </pre>
  
* **URL**

  /insertCommentProduct

* **Método:**

  `POST`
  
*  **Parâmetros de URL**

   Nenhum

* **Parâmetros de dados**

  **Obrigatório:**
 
   `nameClient=[string]`
   `idProduct=[integer]`
   
   
   **Opcional:**
 
   `image=[string]`
   `nStars=[integer]`
   `text=[string]`

* **Resposta de sucesso:**

  * **StatusCode:** 200 <br />
    **Message:** `{ "Comentário criado com sucesso" }`
 
* **Resposta de erro:**

  * **StatusCode:** 404 <br />
    **Message:** `{ motivo do erro }`

  OU

  * **StatusCode:** 404 <br />
    **Message:** `{ "Comentário criado sem sucesso" }`
</details>


## Comentário acerca do Trabalhador

<details>
  <summary>Criar</summary>
  <pre> Insere dados de um comentário acerca de um trabalhador em formato JSON. </pre>
  
* **URL**

  /insertCommentWorker

* **Método:**

  `POST`
  
*  **Parâmetros de URL**

   Nenhum

* **Parâmetros de dados**

  **Obrigatório:**
 
   `nameClient=[string]`
   `idWorker=[integer]`
   
   
   **Opcional:**
 
   `image=[string]`
   `nStars=[integer]`
   `text=[string]`

* **Resposta de sucesso:**

  * **StatusCode:** 200 <br />
    **Message:** `{ "Comentário criado com sucesso" }`
 
* **Resposta de erro:**

  * **StatusCode:** 404 <br />
    **Message:** `{ motivo do erro }`

  OU

  * **StatusCode:** 404 <br />
    **Message:** `{ "Comentário criado sem sucesso" }`
</details>


## Restaurante

<details>
  <summary>Criar</summary>
  <pre> Insere dados de um restaurante em formato JSON. </pre>
  
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
</details>




## Utilizador
    
<details>
  <summary>Criar</summary>
  <pre> Insere dados de um utilizador em formato JSON. </pre>
  
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
</details>



## Log
    
<details>
  <summary>Criar</summary>
  <pre> Insere dados de uma log em formato JSON. </pre>
  
* **URL**

  /insertLog

* **Método:**

  `POST`
  
*  **Parâmetros de URL**

   Nenhum

* **Parâmetros de dados**

  **Obrigatório:**
 
   `dateTime=[dateTime]`
   `idUser=[integer]`
   `type=[string]`
   `titleLog=[string]`
   
   **Opcional:**
 
   `resume=[string]`

* **Resposta de sucesso:**

  * **StatusCode:** 200 <br />
    **Message:** `{ "Log criada com sucesso" }`
 
* **Resposta de erro:**

  * **StatusCode:** 404 <br />
    **Message:** `{ motivo do erro }`

  OU

  * **StatusCode:** 404 <br />
    **Message:** `{ "Log criada sem sucesso" }`
</details>
