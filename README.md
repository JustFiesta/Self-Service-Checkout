# Self-Service-Checkout

This repository contains code for self service checkout using PL/pgSQL project. Made in C#, with Microsoft Forms.

<hr>

## Preparation and installation

1. Install postgresql
2. Create database named SSCDB
3. Import database via "psql -d SSCDB -U postgres -f .\dbexport_utf8.pgsql" (if needed change DB name or user)
4. Download the installer
5. Run the setup.exe or .msi file

NOTE: postgres is reqiured running. Change initial DB credentials in Sscdb_context connection string if needed

<hr>

## Functionality

### UI Usage - User

* Click to enter the shop catalog panel
* Scan the product code (insert product code) / choose product from the list panel
* Confirm amout of product
* Checkout
* Insert loyality card / create new card
* Choose payment method

### UI Usage - Checkout Assistant Panel

* Verify consumer age
  * Insert Checkout Assistant code
* Assist with prduct removal from cart
  * Insert Checkout Assistant code
  * Remove product from cart

### UI Usage - Admin

1. In start panel click red login icon in top left corner
2. Log as administrator

Database CRUD:
* Employee CRUD - based on Entity Framework
* Product CRUD - based on PGSQL
  