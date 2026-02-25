# Introducción y Visión General

## 1. **Introducción** Cafetería *"CoffeeNet"*
El presente documento describe los lienamientos generales para el desarrollo del sistema **CoffeeNet**, una solución web diseñada para digitalizar y optimizar los procesos operativos de una cafetería.

---

## 1.1 **Propósito del Sistema**
El software tiene como finalidad optimizar la toma de pedidos, la gestión de usuarios y el control de inventario. Busca reducir los tiempos de atención, minimizar errores en la comanda y proporcionar al administrador una visión clara del flujo de pedidos y el stock disponible.

---

## 1.2 **Objetivos del Proyecto**
*General* Implementar un sistema web que centralice la operación de una cafetería.
*Específicos* 
    1. Agilizar el proceso de toma de pedidos (con o sin registro)
    2. Facilitar la administración de productos y stock
    3. Garantizar la integridad de los datos históricos mediante eliminaciones lógicas

---

## 2. **Alcance del Sistema**

## 2.1 **Funcionalidades Incluidas (In-Scope)
- Módulo Cliente:
    - Visualización del menú digital con categorías
    - Resgitro de usuarios y login
    - Pedido como invitado (formulario de datos)
    - Historial y estado de pedidos
    - Personalización de pedidos

- Módulo Administrador:
    - CRUD de productos y usuarios (con eliminación lógica)
    - Control de inventario (entrada de stock)
    - Notificación de pedidos vía correo electrónico
    - Historial de pedidos general y por cliente

## 2.2 **Fuera del Alcance (Out-of-Scope)
- Módulo Cliente:
    - Pasarela de pagos: Se paga contra entrega
    - Módulo de Delivery: No incluye mapas de envío solo estado del pedido
    - App Móvil Nativa: El acceso es únicamente vía navegador Web

---


## 3. Stakeholders
|    *Rol*   |             *Descripción*              |                       *Interés Principal*                    |
| Cliente    | Usuario final que consume los datos    | Rapidez en el pedido y facilidad de uso                      |
| Admin      | Dueño o encargado de la cafetería      | Control de inventario, recepción de pedidos y estadísiticas  |  
| Devs       | Estudiantes responsables del proyecto  | Cumplimiento de requisitos y calidad de código               |


## 4. Versión de Aplicación
- V.1.0.0
