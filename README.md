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
## Modifiche apportate al metodo dgDati_LoadingRow
Il metodo dgDati_LoadingRow è stato aggiornato per colorare le righe di giallo se il numero di telefono inizia con il numero '3'.
```namespace Eugenio.Malenchi._4i.WPFtelefono
{
    public partial class MainWindow : Window
    {
        // ... (resta invariato)
        private void dgDati_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            Contatto c = e.Row.Item as Contatto;
            if (c != null)
            {
                if (c.Pk == 0)
                {
                    e.Row.Background = Brushes.Red;
                    e.Row.Foreground = Brushes.White;
                }
                else if (c.Numero.StartsWith("3"))
                {
                    e.Row.Background = Brushes.Yellow;
                    e.Row.Foreground = Brushes.White;
                }
            }
        }
        // ...
    }
}
```
