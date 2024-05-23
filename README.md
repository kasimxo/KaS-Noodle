# Noodle

Noodle permite el procesamiento automático de Boletines Oficiales para la creación de marcos de competencias para Moodle.

## Índice

- Qué es Noodle
- Cómo utilizar Noodle
- Manual de usuario
  - Navegación por la aplicación
  - Procesado de archivos y generación de competencias
  - Edición de competencias
  - Exportación de competencias

## Qué es Noodle

Noodle es una aplicación gratuita que permite el procesado automático de Boletines Oficiales para la creación y edición de marcos de competencias para Moodle. 

Esta pensada para agilizar las gestiones y procedimientos que los profesores deben llevar a cabo para preparar sus cursos dentro de esta plataforma educativa. 

Además, permite compartir estos marcos de competencias entre usuarios, ya sea dentro de la propia aplicación, o compartiendo los archivos csv que son generados.

## Cómo utilizar Noodle

En el apartado de Releases se encuentra la última versión publicada de Noodle. Allí, se puede descaragar el archivo NoodleSetUp.exe, que es un archivo de instalación automática. Una vez descargado, basta que se ejecute y se sigan los pasos del asistente de instalación para poder utilizar Noodle.

Si por el contrario se prefiere realizar una instalación sin archivos ejecutables, se puede clonar el repositorio y utilizarlo en VisualStudio o un entorno compatible con aplicaciones .NET.

## Manual de usuario

### Navegación por la aplicación

En todo momento el usuario tiene a su disposición un menú lateral que le muestra las distintas secciones que componen Noodle y le permiten navegar entre ellas. Para navegar a cualquier sección, basta con que el usuario haga clic sobre ella. 
Además, este menú localiza al usuario dentro de la aplicación, ya que identifica aquella sección en la que se encuentra.

Por otro lado, las distintas ventanas incluyen botones de navegación propios, como “Volver” o “Siguiente”, que guían al usuario a seguir los pasos necesarios para completar un ciclo de procesamiento de archivos.

### Procesado de archivos y generación de competencias

Se puede acceder al procesado de archivos desde la pantalla de “Carga”. Los botones de “Seleccionar” abren una ventana desde la que se puede seleccionar el archivo con el explorador de archivos del sistema. Si el usuario lo prefiere, se puede arrastrar directamente el archivo al área inferior, que detectará el tipo de formato automáticamente.

Una vez el usuario haya seleccionado o arrastrado el archivo, el procesamiento comienza de forma automática, sin necesidad de ninguna acción por parte del usuario. Cuando haya finalizado el procesamiento, el resultado se mostrará en la pantalla de “Editar”.

### Visualización de competencias

En la vista de competencias se muestran todas las competencias extraídas de un archivo en una misma columna en la parte izquierda de la pantalla. Para acceder a aquellas competencias que quedan fuera de la pantalla, el usuario puede utilizar la barra de scroll vertical o pulsar y arrastrar el ratón. 

Para mostrar el contenido de una de estas competencias, como por ejemplo sus resultados de aprendizaje y criterios de evaluación, el usuario debe hacer clic sobre ella.

Esto abre una vista detalle de la competencia, que ocupa la mayor parte de la pantalla. Además, modifica el color de la competencia seleccionada, para que el usuario la pueda identificar fácilmente. Para abrir el detalle de otra competencia, únicamente es necesario clicar sobre ella, ya que se actualizan los datos automáticamente.

### Edición de competencias

Si el usuario identifica un error en una competencia, o desea modificar el contenido de alguna de ellas, desde la vista detalle puede hacer clic sobre el botón “Editar”.

La pantalla de edición permite al usuario modificar cualquier contenido de la competencia con un simple clic. Además, permite visualizar el archivo original en la mitad izquierda de la pantalla, siempre que todavía se encuentre en el dispositivo, para que resulte más sencillo este proceso. Automáticamente el archivo se abre en la página correspondiente a la competencia que está siendo editada.

Al hacer clic sobre cualquier texto, se abre un campo de texto en el que el usuario puede escribir y modificar el texto de cualquier forma.

Para guardar las modificaciones, el usuario debe pulsar el botón “Guardar”. Si pulsa “Volver”, habiendo realizado cambios, aparecerá un mensaje de confirmación avisando de que perderá los cambios no guardados. Por último, cualquier cambio no guardado se identifica con un color distinto al resto.

### Exportación de competencias

El acceso a la exportación de competencias se puede realizar con el menú lateral o, desde la pantalla de ver competencias, a través del botón “Siguiente”.

La vista de exportación permite al usuario seleccionar aquellas competencias que desee exportar. Además, para mejorar la experiencia del usuario se han añadido dos botones, “Seleccionar todo” y “Eliminar selección”, que permiten agilizar el proceso. Para seleccionar una competencia, se debe hacer clic en el cuadro de selección junto al nombre de la misma.

Una vez el usuario esté satisfecho con su selección, pulsando el botón “Exportar”, abrirá un cuadro de diálogo que le permitirá seleccionar el nombre y directorio para el archivo de exportación.
