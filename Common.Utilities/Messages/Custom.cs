using System.Windows;

namespace Common.Utilities
{
    public static partial class Message
    {
        public static class Custom
        {
            public static MessageBoxResult Error(string message)
            {
                return DefaultTemplate(message, "Erro",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

            public static MessageBoxResult Information(string message)
            {
                return DefaultTemplate(message, "Caixa de Informação",
                    MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }

            public static MessageBoxResult Question(string message)
            {
                return DefaultTemplate(message, "Caixa de Confirmação",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
            }

            public static MessageBoxResult Warning(string message)
            {
                return DefaultTemplate(message, "Aviso",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }


            private static MessageBoxResult DefaultTemplate
            (string message
            , string title
            , MessageBoxButton messageBoxButton
            , MessageBoxImage messageBoxImage)
            {
                return MessageBox.Show(message, $"{title} - ", // {ComfyZone.Properties.Resources.ApplicationName}
                    messageBoxButton, messageBoxImage);
            }
        }
    }
}
