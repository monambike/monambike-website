using Microsoft.Toolkit.Uwp.Notifications;
using System.Windows;

namespace ComfyZone.Desktop
{
    internal static class Youtube
    {
        public static string Names { get; set; }

        public static string ShortDescription { get; set; }

        public static string Playlist { get; set; }

        public static string ReturnYoutubeDescription()
        {
            return $@"
            feat: {Names}
            {ShortDescription}

            🎮 Jogo: ""{ShortDescription}""
            📂 Playlist: ""{Playlist}""

            🔗 Links
            ------------------------------ | ------------------------------
            📹 Canal Principal: @monambike 
            🎬 Lives: twitch.tv/Monambike
            📷 Instagram: instagram.com/Monambike

            🎞️Trechos do Vídeo:
            ------------------------------ | ------------------------------

            bo dia
            ";
        }

        internal static void CopyToClipboard()
        {
            Clipboard.SetText(ReturnYoutubeDescription());

            new ToastContentBuilder()
                .AddText("Copiado para Área de Transferência")
                .AddText("A descrição do youtube foi copiada para a área de transferência.")
                .Show();
        }
    }
}
