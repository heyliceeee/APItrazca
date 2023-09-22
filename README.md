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
| `nutritionalValue` | string  | Valores nutricionais do produto. |     Não     |

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
  <pre> Criar um pedido. </pre>

  **[POST]** `{{host}}/insertOrder`
  
**Body**
| Campo      | Tipo | Descrição                           | Obrigatório |
|:---------------|:----:|:------------------------------------|:-----------:|
| `timeUserAddress`     | datetime  | Horário estimado de chegada.         |     Sim     |  
| `idCart` | integer  | ID do carrinho. |     Sim     |             

```json
{
    "timeUserAddress": "06/10/23 15:24",
    "idCart": 1
}
```
**Response**

201 Created
```json
{
    "Pedido criado com sucesso"
}
```
404 Error
```json
{
    "Pedido criado sem sucesso"
}
```
</details>


## Carrinho

<details>
  <summary>Criar</summary>
  <pre> Criar um carrinho. </pre>

  **[POST]** `{{host}}/insertCart`
  
**Body**
| Campo      | Tipo | Descrição                           | Obrigatório |
|:---------------|:----:|:------------------------------------|:-----------:|
| `subtotal`     | decimal  | Subtotal do carrinho.         |     Sim     |  
| `deliveryFee` | decimal  | Taxa de entrega do carrinho. |     Sim     |             
| `discount` | decimal  | Desconto do carrinho. |     Sim     |   
| `total` | decimal  | Total do carrinho. |     Sim     |   
| `idUser` | integer  | ID do utilizador do carrinho. |     Sim     |   

```json
{
    "subtotal": 8.99,
    "deliveryFee": 2.00,
    "discount": 0.00,
    "total": 10.99,
    "idUser": 1
}
```
**Response**

201 Created
```json
{
    "Carrinho criado com sucesso"
}
```
404 Error
```json
{
    "Carrinho criado sem sucesso"
}
```
</details>


<details>
  <summary>Editar</summary>
  <pre> Editar um carrinho. </pre>

  **[PUT]** `{{host}}/editCart/{id}`
  
**Body**
| Campo      | Tipo | Descrição                           | Obrigatório |
|:---------------|:----:|:------------------------------------|:-----------:|
| `status`     | string  | Estado do carrinho.         |     Sim     |
| `subtotal`     | decimal  | Subtotal do carrinho.         |     Não     |  
| `deliveryFee` | decimal  | Taxa de entrega do carrinho. |     Não     |             
| `discount` | decimal  | Desconto do carrinho. |     Não     |   
| `total` | decimal  | Total do carrinho. |     Não     |   
| `idUser` | integer  | ID do utilizador do carrinho. |     Não     |   

```json
{
    "status": "updated",
    "subtotal": 8.99,
    "deliveryFee": 2.00,
    "discount": 0.00,
    "total": 10.99,
    "idUser": 1
}
```
**Response**

200 Updated
```json
{
    "Dados do carrinho atualizados com sucesso"
}
```

404 Error
```json
{
    "Dados do carrinho atualizados sem sucesso"
}
```
</details>


## Item do Carrinho

<details>
  <summary>Criar</summary>
  <pre> Criar um item no carrinho. </pre>

  **[POST]** `{{host}}/insertCartItem`
  
**Body**
| Campo      | Tipo | Descrição                           | Obrigatório |
|:---------------|:----:|:------------------------------------|:-----------:|
| `quantity`     | integer  | Quantidade do item.         |     Sim     |
| `idProduct`     | integer  | ID do produto do item.         |     Sim     |
| `idCart`     | integer  | ID do carrinho do item.         |     Sim     |
| `noteProduct`     | string  | Nota do produto do item.       |     Não     |

```json
{
    "quantity": 2,
    "idProduct": 1,
    "idCart": 1,
    "noteProduct": "Extra queijo e sem alface"
}
```
**Response**

201 Created
```json
{
    "Item do carrinho criado com sucesso"
}
```

404 Error
```json
{
    "Item do carrinho criado sem sucesso"
}
```
</details>


<details>
  <summary>Editar</summary>
  <pre> Editar um item no carrinho. </pre>

  **[PUT]** `{{host}}/editCartItem/{id}`
  
**Body**
| Campo      | Tipo | Descrição                           | Obrigatório |
|:---------------|:----:|:------------------------------------|:-----------:|
| `status`     | string  | Estado do item.         |     Sim     |
| `quantity`     | integer  | Quantidade do item.         |     Não     |
| `idProduct`     | integer  | ID do produto do item.         |     Não     |
| `idCart`     | integer  | ID do carrinho do item.         |     Não     |
| `noteProduct`     | string  | Nota do produto do item.       |     Não     |

```json
{
    "status": "updated",
    "quantity": 2,
    "idProduct": 1,
    "idCart": 1,
    "noteProduct": "Extra queijo e sem alface"
}
```
**Response**

200 Updated
```json
{
    "Dados do item do carrinho atualizados com sucesso"
}
```

404 Error
```json
{
    "Dados do item do carrinho atualizados sem sucesso"
}
```
</details>


## Comentário do Produto

<details>
  <summary>Criar</summary>
  <pre> Criar um comentário acerca do produto.</pre>

  **[POST]** `{{host}}/insertCommentProduct`
  
**Body**
| Campo      | Tipo | Descrição                           | Obrigatório |
|:---------------|:----:|:------------------------------------|:-----------:|
| `nameClient`     | string  | Nome do Cliente do comentário.         |     Sim     |
| `idProduct`     | integer  | ID do produto do comentário.         |     Sim     |
| `image`     | string  |  Imagem do produto do comentário.         |     Não     |
| `nStars`     | integer  | Número de estrelas do produto do comentário.       |     Não     |
| `text`     | string  | Texto do comentário.       |     Não     |

```json
{
    "nameClient": "Alice Dias",
    "idProduct": 1,
    "image": "https://th.bing.com/th/id/OIP.pM-lTcgk7puTjjkCun-KAAHaFj?w=236&h=180&c=7&r=0&o=5&pid=1.7",
    "nStars": 5,
    "text": "O Crispy Chicken estava delicioso!"
}
```
**Response**

201 Created
```json
{
    "Comentário criado com sucesso"
}
```

404 Error
```json
{
    "Comentário criado sem sucesso"
}
```
</details>


## Comentário do Trabalhador

<details>
  <summary>Criar</summary>
  <pre> Criar um comentário acerca do trabalhador.</pre>

  **[POST]** `{{host}}/insertCommentWorker`
  
**Body**
| Campo      | Tipo | Descrição                           | Obrigatório |
|:---------------|:----:|:------------------------------------|:-----------:|
| `nameClient`     | string  | Nome do Cliente do comentário.         |     Sim     |
| `idWorker`     | integer  | ID do trabalhador do comentário.         |     Sim     |
| `image`     | string  |  Imagem do trabalhador do comentário.         |     Não     |
| `nStars`     | integer  | Número de estrelas do trabalhador do comentário.       |     Não     |
| `text`     | string  | Texto do comentário.       |     Não     |

```json
{
    "nameClient": "Alice Dias",
    "idWorker": 1,
    "image": "https://th.bing.com/th/id/OIP.pM-lTcgk7puTjjkCun-KAAHaFj?w=236&h=180&c=7&r=0&o=5&pid=1.7",
    "nStars": 5,
    "text": "Um senhor 5 estrelas! Entregou o pedido rápido e de forma segura."
}
```
**Response**

201 Created
```json
{
    "Comentário criado com sucesso"
}
```

404 Error
```json
{
    "Comentário criado sem sucesso"
}
```
</details>


## Restaurante

<details>
  <summary>Criar</summary>
  <pre> Criar um restaurante.</pre>

  **[POST]** `{{host}}/insertRestaurant`
  
**Body**
| Campo      | Tipo | Descrição                           | Obrigatório |
|:---------------|:----:|:------------------------------------|:-----------:|
| `name`     | string  | Nome do restaurante.         |     Sim     |
| `address`     | string  | Morada do restaurante.       |     Sim     |
| `image`     | string  | Imagem do restaurante.       |     Não     |
| `nStars`     | integer  | Número de estrelas do restaurante.       |     Não     |
| `allCategories`     | string  | As categorias dos produtos do restaurante.       |     Não     |
| `cheapPriceProduct`     | integer  | ID do produto mais barato do restaurante.       |     Não     |
| `distanceUserAddress`     | integer  | Distância do cliente até ao restaurante.       |     Não     |
| `description`     | string  | Descrição do restaurante.       |     Não     |

```json
{
    "name": "Burger King",
    "address": "Rua do Burger King, nº5 Portimão",
    "image": "https://th.bing.com/th/id/OIP.tiIwgoPkXKdA_ehHFs12LQHaHh?w=164&h=180&c=7&r=0&o=5&pid=1.7",
    "nStars": 5,
    "allCategories": "Hamburger, Frango Frito, Batata Frita, Milkshake, Gelado, Waffle",
    "cheapPriceProduct": 1,
    "distanceUserAddress": 6,
    "description": "Convide a sua família e venha conhecer o melhor restaurante de fast food do MUNDO!"
}
```
**Response**

201 Created
```json
{
    "Restaurante criado com sucesso"
}
```

404 Error
```json
{
    "Restaurante criado sem sucesso"
}
```
</details>


## Utilizador

<details>
  <summary>Criar</summary>
  <pre> Criar um utilizador.</pre>

  **[POST]** `{{host}}/insertUser`
  
**Body**
| Campo      | Tipo | Descrição                           | Obrigatório |
|:---------------|:----:|:------------------------------------|:-----------:|
| `name`     | string  | Nome do utilizador.         |     Sim     |
| `role`     | string  | Tipo de utilizador.         |     Sim     |
| `address`     | string  | Morada do utilizador.       |     Sim     |
| `email`     | string  | Email do utilizador.       |     Sim     |
| `password`     | string  | Palavra-passe do utilizador.       |     Sim     |
| `paypal`     | string  | Paypal do utilizador.       |     Sim     |
| `phoneNumber`     | string  | Número de telemóvel do utilizador.       |     Não     |

```json
{
    "name": "Alice Dias",
    "role": "customer",
    "address": "Rua da minha casa nº75, Portimão",
    "email": "alicedias@email.com",
    "password": "**********",
    "paypal": "alicedias26",
    "phoneNumber": "+351911111111"
}
```
**Response**

201 Created
```json
{
    "Utilizador criado com sucesso"
}
```

404 Error
```json
{
    "Utilizador criado sem sucesso"
}
```
</details>


## Log

<details>
  <summary>Criar</summary>
  <pre> Criar uma log.</pre>

  **[POST]** `{{host}}/insertLog`
  
**Body**
| Campo      | Tipo | Descrição                           | Obrigatório |
|:---------------|:----:|:------------------------------------|:-----------:|
| `dateTime`     | string  | Hora da log.         |     Sim     |
| `idUser`     | integer  | ID do utilizador da log.         |     Sim     |
| `type`     | string  | Tipo de log.         |     Sim     |
| `titleLog`     | string  | Título da log.         |     Sim     |
| `resume`     | string  | Resumo da log.       |     Não     |

```json
{
    "name": "Alice Dias",
    "role": "customer",
    "address": "Rua da minha casa nº75, Portimão",
    "email": "alicedias@email.com",
    "password": "**********",
    "paypal": "alicedias26",
    "phoneNumber": "+351911111111"
}
```
**Response**

201 Created
```json
{
    "Log criada com sucesso"
}
```

404 Error
```json
{
    "Log criada sem sucesso"
}
```
</details>
