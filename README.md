# 🌌 NEBULA V5 — Asistente Inteligente de Productividad

NEBULA es un asistente virtual diseñado para mejorar la organización personal,
facilitar la consulta de información en línea, gestionar tareas y proporcionar
herramientas inteligentes desde una interfaz moderna y minimalista con estética galáctica.

Este proyecto está desarrollado en **C# (.NET Framework, WinForms)** y está
orientado a estudiantes que buscan una herramienta
rápida e intuitiva parfa organizarse y trabjar sus diferentes actividades con más facilidad.

---

## ✨ Características principales

### 🔍 **Buscador en línea integrado**
- Navegador interno con modo IE11 forzado para compatibilidad.
- Bloqueo de ventanas nuevas para navegación controlada.
- Botones de navegación: atrás, adelante, recargar, inicio.
- Soporte de historial con guardado de enlaces.

### 🗂️ **Gestor de tareas**
- Creación de tarjetas de tareas con:
  - título,
  - descripción,
  - prioridad,
  - fecha/hora límite.
- Eliminación individual.
- Diseño responsivo en FlowLayoutPanel.

### 🧠 **Mini Chat (respuestas rápidas)**
- Respuestas basadas en diccionario con ampliación asegurada.
- Validaciones para evitar errores.
- (El chat funciona a traves de u  diccionario por lo que tiene respuertas limitadas. En el futuro se desea trabajar esa parte.)

### 🔑 **Sistema de inicio de sesión**
- Registro y login de usuarios utilizando un archivo plano.
- Validación de credenciales.
- Redirección automática al panel principal.

### 📝 **Historial integrado**
- Guardado automático de enlaces visitados.
- Visualización en lista.
- Apertura directa desde el historial.
- Eliminación individual o limpiar todo.

### 🎨 **Interfaz NEBULA (Diseño UI)**
Todos los formularios incluyen:
- Fondos degradados galácticos (negro → azul espacial → morado).
- Sombreado suave y colores consistentes.
- Animación y distribución responsiva según tamaño.

---

## 🚀 Tecnologías utilizadas

- **Lenguaje:** C#  
- **Framework:** .NET Framework WinForms  
- **UI:** GDI+, LinearGradientBrush, ColorBlend  
- **Persistencia ligera:** Archivos `.txt`  
- **Control:** WebBrowser (modo IE11 forzado)  

---

## 📂 Estructura del proyecto
NEBULA_V5/
│── Datos/
│ └── usuario.txt
│── Presentacion/
│ ├── FrmLogin.cs
│ ├── FrmRegistro.cs
│ ├── FrmInicio.cs
│ ├── FrmBusquedasOnline.cs
│ ├── FrmHistorial.cs
│ ├── FrmTareas.cs
│ ├── FrmCrearTarea.cs
│ └── … (archivos Designer)
│── Program.cs
│── NEBULA_V5.csproj
│── README.md
└── packages.config


Autores:
Elydariana de León García Espinoza
Julián Alonso Torrez Valdivia
Kendra Alexandra Reyes Silva 
INGENIERÍA EN SISTEMAS DE INFORMACION. UNIVERSIDAD AMAERICANA

