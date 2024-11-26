/*
 * @fileoverview    {Mercancia}
 *
 * @version         2.0
 *
 * @author          Dyson Arley Parra Tilano <dysontilano@gmail.com>
 *
 * @copyright       Dyson Parra
 * @see             github.com/DysonParra
 *
 * History
 * @version 1.0     Implementation done.
 * @version 2.0     Documentation added.
 */
using System;
using System.ComponentModel.DataAnnotations;

/**
 * TODO: Description of {@code Mercancia}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class Mercancia {

        [Key]
        public Int64? IntIdMercancia { get; set; }
        public String? StrNombreMercancia { get; set; }
        public String? StrDescripcionMercancia { get; set; }

    }

}