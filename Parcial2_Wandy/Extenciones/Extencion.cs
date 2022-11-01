using Radzen;

namespace Parcial2_Wandy.Extenciones{
    public static class Extencion{
          public static void ShowNotification(this NotificationService notifier, string mensaje, NotificationSeverity severity = NotificationSeverity.Success)
        {
            var message = new NotificationMessage
            {
                Severity = severity,
                Summary = mensaje
            };

            notifier.Notify(message);
        }
    }
}