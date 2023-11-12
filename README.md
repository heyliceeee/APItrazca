# "Traz Cá" app API
## Product

<details>
  <summary>Create</summary>
  <pre> Create a product. </pre>

  **[POST]** `{{host}}/insertProduct`
  
**Body**
| Field      | Type | Description                           | Mandatory |
|:---------------|:----:|:------------------------------------|:-----------:|
| `name`     | string  | Product's name.         |     Yes     |  
| `price` | double  | Price of the product. |     Yes     |             
| `category` | string  | Product category. |     Yes     |
| `idRestaurant` | integer  | Product restaurant ID. |     Yes     |
| `description` | string  | Product Description. |     No     |
| `image` | string  | Product image. |     No     |
| `nStars` | integer  | Number of stars for the product. |     No     |
| `allergens` | string  | Product allergens. |     No     |
| `mainIngredients` | string  | Main ingredients of the product. |     No     |
| `nutritionalValue` | string  | Nutritional values of the product. |     No     |

```json
{
    "name": "Crispy Chicken",
    "price": 1.00,
    "category": "Hamburger",
    "idRestaurant": 1,
    "description": "Crispy on the outside, soft on the inside. The best chicken with a crispy breading, freshly cut tomato, fresh lettuce and mayonnaise on a freshly toasted seed bread. A true work of art.",
    "image": "https://www.nit.pt/wp-content/uploads/2020/10/6f7b4074e48a10d14e8cd990c4b646e7-754x394.jpg",
    "nStars": 5,
    "allergens": "Gluten, Egg, Celery, Sesame, May contain lupins, May contain mustard, May contain soy protein, May contain dairy products, May contain SO2 and sulfites",
    "mainIngredients": "Lettuce, Tomato, Mayonnaise",
    "nutritionalValue": "Weight 189g, Calories 516kcal, Proteins 16.4g, Carbohydrates 42.2g, Sugar 6.3g, Added sugar 0.9g, Fats 30.5g, Monounsaturated fats 12g, Pollinsaturated fats 13.3g, Saturated fat 5.6g, Hydrogenated trans fat 0g, Natural trans fat 0.2 g, Trans fat 0.2g, Fiber 3.3g, Sodium 725mg, Salt 1812mg, Added salt 1812mg"
}
```
**Response**

201 Created
```json
{
    "Product successfully created"
}
```
404 Error
```json
{
    "Product created unsuccessfully"
}
```
</details>


## Order

<details>
  <summary>Create</summary>
  <pre> Create an order. </pre>

  **[POST]** `{{host}}/insertOrder`
  
**Body**
| Field      | Type | Description                           | Mandatory |
|:---------------|:----:|:------------------------------------|:-----------:|
| `timeUserAddress`     | datetime  | Estimated arrival time.        |     Yes     |  
| `idCart` | integer  | Cart ID. |     Yes     |             

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
    "Order successfully created"
}
```
404 Error
```json
{
    "Order created unsuccessfully"
}
```
</details>


## Cart

<details>
  <summary>Create</summary>
  <pre> Create a cart. </pre>

  **[POST]** `{{host}}/insertCart`
  
**Body**
| Field      | Type | Description                           | Mandatory |
|:---------------|:----:|:------------------------------------|:-----------:|
| `subtotal`     | decimal  | Cart subtotal.         |     Yes     |  
| `deliveryFee` | decimal  | Cart delivery fee. |     Yes     |             
| `discount` | decimal  | Cart discount. |     Yes     |   
| `total` | decimal  | Cart total. |     Yes     |   
| `idUser` | integer  | Cart user ID. |     Yes     |   

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
    "Cart successfully created"
}
```
404 Error
```json
{
    "Cart created unsuccessfully"
}
```
</details>


<details>
  <summary>Edit</summary>
  <pre> Edit a cart. </pre>

  **[PUT]** `{{host}}/editCart/{id}`
  
**Body**
| Field      | Type | Description                           | Mandatory |
|:---------------|:----:|:------------------------------------|:-----------:|
| `status`     | string  | Cart status.         |     Yes     |
| `subtotal`     | decimal  | Cart subtotal.         |     No     |  
| `deliveryFee` | decimal  | Cart delivery fee. |     No     |             
| `discount` | decimal  | Cart discount. |     No     |   
| `total` | decimal  | Cart total. |     No     |   
| `idUser` | integer  | Cart user ID. |     No     |   

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
    "Cart details updated successfully"
}
```

404 Error
```json
{
    "Cart details updated unsuccessfully"
}
```
</details>


## Cart Item

<details>
  <summary>Create</summary>
  <pre> Create an item in the cart. </pre>

  **[POST]** `{{host}}/insertCartItem`
  
**Body**
| Field      | Type | Description                           | Mandatory |
|:---------------|:----:|:------------------------------------|:-----------:|
| `quantity`     | integer  | Item quantity.         |     Yes     |
| `idProduct`     | integer  | Product ID of the item.         |     Yes     |
| `idCart`     | integer  | Item cart ID.       |     Yes     |
| `noteProduct`     | string  | Item Product Note.       |     No     |

```json
{
    "quantity": 2,
    "idProduct": 1,
    "idCart": 1,
    "noteProduct": "Extra cheese and no lettuce"
}
```
**Response**

201 Created
```json
{
    "Cart item created successfully"
}
```

404 Error
```json
{
    "Cart Item created unsuccessfully"
}
```
</details>


<details>
  <summary>Edit</summary>
  <pre> Edit an item in the cart. </pre>

  **[PUT]** `{{host}}/editCartItem/{id}`
  
**Body**
| Field      | Type | Description                           | Mandatory |
|:---------------|:----:|:------------------------------------|:-----------:|
| `status`     | string  | Item status.         |     Yes     |
| `quantity`     | integer  | Item quantity.         |     No     |
| `idProduct`     | integer  | Product ID of the item.         |     No     |
| `idCart`     | integer  | Item cart ID.         |     No     |
| `noteProduct`     | string  | Item product note.       |     No     |

```json
{
    "status": "updated",
    "quantity": 2,
    "idProduct": 1,
    "idCart": 1,
    "noteProduct": "Extra cheese and no lettuce"
}
```
**Response**

200 Updated
```json
{
    "Cart item data updated successfully"
}
```

404 Error
```json
{
    "Cart item data updated unsuccessfully"
}
```
</details>


## Product Comment

<details>
  <summary>Create</summary>
  <pre> Create a review about the product.</pre>

  **[POST]** `{{host}}/insertCommentProduct`
  
**Body**
| Field      | Type | Description                           | Mandatory |
|:---------------|:----:|:------------------------------------|:-----------:|
| `nameClient`     | string  | Customer name of the comment.         |     Yes     |
| `idProduct`     | integer  | Product ID of the comment.         |     Yes     |
| `image`     | string  |  Product image from the comment.      |     No     |
| `nStars`     | integer  | Number of stars for the product in the review.       |     No     |
| `text`     | string  | Comment text.       |     No     |

```json
{
    "nameClient": "Alice Dias",
    "idProduct": 1,
    "image": "https://th.bing.com/th/id/OIP.pM-lTcgk7puTjjkCun-KAAHaFj?w=236&h=180&c=7&r=0&o=5&pid=1.7",
    "nStars": 5,
    "text": "The Crispy Chicken was delicious!"
}
```
**Response**

201 Created
```json
{
    "Comment successfully created"
}
```

404 Error
```json
{
    "Comment created unsuccessfully"
}
```
</details>


## Worker Comment
<details>
  <summary>Create</summary>
  <pre> Create a comment about the worker. </pre>

  **[POST]** `{{host}}/insertCommentWorker`
  
**Body**
| Field      | Type | Description                           | Mandatory |
|:---------------|:----:|:------------------------------------|:-----------:|
| `nameClient`     | string  | Customer name of the comment.         |     Yes     |
| `idWorker`     | integer  | Comment worker ID.         |     Yes     |
| `image`     | string  |  Image of comment worker.         |     No     |
| `nStars`     | integer  | Number of stars of the comment worker.       |     No     |
| `text`     | string  | Comment text.       |     No     |

```json
{
    "nameClient": "Alice Dias",
    "idWorker": 1,
    "image": "https://th.bing.com/th/id/OIP.pM-lTcgk7puTjjkCun-KAAHaFj?w=236&h=180&c=7&r=0&o=5&pid=1.7",
    "nStars": 5,
    "text": "A 5 star gentleman! Delivered the order quickly and safely."
}
```
**Response**

201 Created
```json
{
    "Comment successfully created"
}
```

404 Error
```json
{
    "Comment created unsuccessfully"
}
```
</details>


## Restaurant

<details>
  <summary>Create</summary>
  <pre> Create a restaurant</pre>

  **[POST]** `{{host}}/insertRestaurant`
  
**Body**
| Field      | Type | Description                           | Mandatory |
|:---------------|:----:|:------------------------------------|:-----------:|
| `name`     | string  | Name of the restaurant.         |     Yes     |
| `address`     | string  | Restaurant address.       |     Yes     |
| `image`     | string  | Image of the restaurant.       |     No     |
| `nStars`     | integer  | Number of restaurant stars.       |     No     |
| `allCategories`     | string  | The restaurant's product categories.       |     No     |
| `cheapPriceProduct`     | integer  | ID of the cheapest product in the restaurant.       |     No     |
| `distanceUserAddress`     | integer  | Distance from the customer to the restaurant.       |     No     |
| `description`     | string  | Description of the restaurant.       |     No     |

```json
{
    "name": "Burger King",
    "address": "123 Main Street East Unit 6",
    "image": "https://th.bing.com/th/id/OIP.tiIwgoPkXKdA_ehHFs12LQHaHh?w=164&h=180&c=7&r=0&o=5&pid=1.7",
    "nStars": 5,
    "allCategories": "Hamburger, Fried Chicken, French Fries, Milkshake, Ice Cream, Waffle",
    "cheapPriceProduct": 1,
    "distanceUserAddress": 6,
    "description": "Invite your family and come and discover the best fast food restaurant in the WORLD!"
}
```
**Response**

201 Created
```json
{
    "Restaurant successfully created"
}
```

404 Error
```json
{
    "Restaurant created unsuccessfully"
}
```
</details>


## User

<details>
  <summary>Create</summary>
  <pre> Create a user.</pre>

  **[POST]** `{{host}}/insertUser`
  
**Body**
| Field      | Type | Description                           | Mandatory |
|:---------------|:----:|:------------------------------------|:-----------:|
| `name`     | string  | User name.         |     Yes     |
| `role`     | string  | User type.         |     Yes     |
| `address`     | string  | User address.       |     Yes     |
| `email`     | string  | User email.       |     Yes     |
| `password`     | string  | User password.       |     Yes     |
| `paypal`     | string  | User Paypal.       |     Yes     |
| `phoneNumber`     | string  | User's mobile phone number.       |     No     |

```json
{
    "name": "Alice Dias",
    "role": "customer",
    "address": "465 Main Street East Unit 9",
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
    "User successfully created"
}
```

404 Error
```json
{
    "User created unsuccessfully"
}
```
</details>


## Log

<details>
  <summary>Create</summary>
  <pre> Create a log.</pre>

  **[POST]** `{{host}}/insertLog`
  
**Body**
| Field      | Type | Description                           | Mandatory |
|:---------------|:----:|:------------------------------------|:-----------:|
| `dateTime`     | string  | Log time.         |     Yes     |
| `idUser`     | integer  | Log user ID.        |     Yes     |
| `type`     | string  | Log type.        |     Yes     |
| `titleLog`     | string  | Log title.         |     Yes     |
| `resume`     | string  | Log summary.       |     No     |

```json
{
    "name": "Alice Dias",
    "role": "customer",
    "address": "465 Main Street East Unit 9",
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
    "Log created successfully"
}
```

404 Error
```json
{
    "Log created unsuccessfully"
}
```
</details>
