## **1. Arquitectura del Sistema**
---

## **2. Stack Tecnológico**

|     *Capa*    |      *Tecnológia*     |        *Justificación*                       |
|---------------|-----------------------|----------------------------------------------|
| Frontend      | Angular               | Más robustez para futura escalabiliad        |
| Backend       | C# Net Core           | Facilidad para API´s                         | 
| Base de Datos | SQLServer             | Relacional, ideal para pedidos e inventarios |
| ORM           | Entity FrameworkCore  | Facilita consultas y migraciones             |

---

## **3. Modelo de Base de Datos**
##  3.1 Diagrama Entidad-Relacion
![alt text](<BD_CoffeeNet (1).png>)

## 3.2 Relaciones
*Se subirá luego..*

---

## **4. Diseño de API**
*Se subirá en la etapa de desarrollo*

---

## **5. Consideraciones de Seguridad**
- *Contraseñas:* Encriptadas con SHA-256/512
- *Autenticación:* JWT (Jason Web Tokens) para sesiones
- *Eliminación Lógica:* Campo *eliminado_en* para no perder el historial
- *Validación:* Todos los inputs del cliente se validan en el backend
- *CORS:* Configurado para aceptar solo peticiones del dominio permitido


