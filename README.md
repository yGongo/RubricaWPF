# RubricaWPF

## Modifica di wpfRubrica per Aggiunta Colonna Numero di Telefono
Questo progetto WPF (Windows Presentation Foundation) chiamato wpfRubrica è stato modificato per aggiungere una colonna aggiuntiva al file CSV contenente il numero di telefono dei contatti. Inoltre, è stata implementata la funzionalità di colorare le righe di giallo nel caso in cui il numero di telefono inizi con il numero '3'.

## Modifiche apportate alla classe Contatto
Nella classe Contatto, è stata aggiunta una proprietà Numero per rappresentare il numero di telefono dei contatti.
``` namespace Eugenio.Malenchi._4i.WPFtelefono
{
    class Contatto
    {
        // ... (resta invariato)
        public string Numero { get => numero; set => numero = value; }
        // ...
    }
}
```
