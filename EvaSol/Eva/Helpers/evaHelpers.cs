using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva.Helpers
{
    public class evaHelpers
    {
        /// <summary>
        /// Clase con funciones auxiliares para el manejo de fechas
        /// </summary>
        public class DateTimeHelper
        {
            public static Dictionary<string, TimeZoneInfo> Zonas = new Dictionary<string, TimeZoneInfo>()
        {
            {"Pacifico", TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time (Mexico)") },
            {"Montaña", TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time (Mexico)") },
            {"Centro", TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time (Mexico)") }
        };

            /// <summary>
            /// Obtiene la Fecha y hora en Ciudad de Mexico
            /// </summary>
            /// <returns></returns>
            public static DateTime GetDateTimeMexicoCity()
            {
                return GetDateTimeMexicoCity(DateTime.UtcNow);
            }

            /// <summary>
            /// Convierte Fecha y Hora UTC a Fecha y Hora en Ciudad de Mexico
            /// </summary>
            /// <param name="time">Fecha y Hora en UTC</param>
            /// <returns></returns>
            public static DateTime GetDateTimeMexicoCity(DateTime time)
            {
                return TimeZoneInfo.ConvertTimeFromUtc(time, Zonas["Centro"]);
            }
        }
    }
}
