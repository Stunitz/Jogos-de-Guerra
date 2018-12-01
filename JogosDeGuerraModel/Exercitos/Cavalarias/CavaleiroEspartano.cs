﻿namespace JogosDeGuerraModel
{
    /// <summary>
    /// Modelo do cavaleiro egipicio
    /// </summary>
    class CavaleiroEspartano : Cavaleiro
    {
        /// <summary>
        /// O caminho de onde a imagem que representara um cavaleiro egipicio no servidor
        /// </summary>
        public override string UriImagem { get; protected set; } = "/Images/PNG/ESPARTA/dir/cavalaria_dir.png";
    }
}
