/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 05/08/2026 */

using System;
using System.Collections.Generic;
using Con_Admin;

namespace Plantilla_Admin
{
    public enum PerfilPermiso
    {
        Admin,
        Taquillero,
        Gerente,
        Soporte,
        Cajero
    }

    public enum AplicacionPermiso
    {
        Peliculas,
        Funciones,
        Salas,
        Cines,
        Promociones,
        Clientes,
        UsuariosPerfiles,
        VentaBoletos,
        CancelacionBoletos,
        Reportes
    }

    public enum AccionPermiso
    {
        Mantenimiento,
        Eliminar,
        Registrar,
        Modificar
    }

    public class PermisosAux
    {
        private readonly If_AsignarPermisos api = new If_AsignarPermisos();

        private readonly Dictionary<string, bool> cache =
            new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase);

        public PerfilPermiso Perfil { get; set; }
        public AplicacionPermiso Aplicacion { get; set; }
        public AccionPermiso Accion { get; set; }

        public PermisosAux() { }

        public PermisosAux(
            PerfilPermiso perfil,
            AplicacionPermiso aplicacion,
            AccionPermiso accion)
        {
            Perfil = perfil;
            Aplicacion = aplicacion;
            Accion = accion;
        }

        public static PermisosAux DeSesion(
            AplicacionPermiso aplicacion,
            AccionPermiso accion)
        {
            PerfilPermiso perfil;

            if (!ObtenerPerfilSesion(out perfil))
                throw new InvalidOperationException(
                    "El perfil de la sesión no es válido."
                );

            return new PermisosAux(
                perfil,
                aplicacion,
                accion
            );
        }

        public bool Permitido()
        {
            string perfilBD = ObtenerNombrePerfil(Perfil);
            string aplicacionBD = ObtenerCodigoAplicacion(Aplicacion);
            string accionBD = ObtenerNombreAccion(Accion);

            if (string.IsNullOrWhiteSpace(perfilBD) ||
                string.IsNullOrWhiteSpace(aplicacionBD) ||
                string.IsNullOrWhiteSpace(accionBD))
            {
                return false;
            }

            if (Perfil == PerfilPermiso.Admin)
                return true;

            string clave =
                perfilBD + "|" +
                aplicacionBD + "|" +
                accionBD;

            if (cache.TryGetValue(clave, out bool valor))
                return valor;

            bool permitido;

            try
            {
                permitido = api.ContarPermisos(
                    perfilBD,
                    aplicacionBD,
                    accionBD
                ) > 0;
            }
            catch
            {
                permitido = false;
            }

            cache[clave] = permitido;

            return permitido;
        }

        public void Refrescar()
        {
            cache.Clear();
        }

        private static bool ObtenerPerfilSesion(
            out PerfilPermiso perfil)
        {
            perfil = PerfilPermiso.Taquillero;

            if (string.IsNullOrWhiteSpace(Sesion.Perfil))
                return false;

            if (Sesion.Perfil.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                perfil = PerfilPermiso.Admin;
                return true;
            }

            if (Sesion.Perfil.Equals("taquillero", StringComparison.OrdinalIgnoreCase))
            {
                perfil = PerfilPermiso.Taquillero;
                return true;
            }

            if (Sesion.Perfil.Equals("gerente", StringComparison.OrdinalIgnoreCase))
            {
                perfil = PerfilPermiso.Gerente;
                return true;
            }

            if (Sesion.Perfil.Equals("soporte", StringComparison.OrdinalIgnoreCase))
            {
                perfil = PerfilPermiso.Soporte;
                return true;
            }

            if (Sesion.Perfil.Equals("cajero", StringComparison.OrdinalIgnoreCase))
            {
                perfil = PerfilPermiso.Cajero;
                return true;
            }

            return false;
        }

        private static string ObtenerNombrePerfil(
            PerfilPermiso perfil)
        {
            switch (perfil)
            {
                case PerfilPermiso.Admin:
                    return "admin";

                case PerfilPermiso.Taquillero:
                    return "taquillero";

                case PerfilPermiso.Gerente:
                    return "gerente";

                case PerfilPermiso.Soporte:
                    return "soporte";

                case PerfilPermiso.Cajero:
                    return "cajero";

                default:
                    return null;
            }
        }

        private static string ObtenerCodigoAplicacion(
            AplicacionPermiso aplicacion)
        {
            switch (aplicacion)
            {
                case AplicacionPermiso.Peliculas:
                    return "APL103";

                case AplicacionPermiso.Funciones:
                    return "APL104";

                case AplicacionPermiso.Salas:
                    return "APL105";

                case AplicacionPermiso.Cines:
                    return "APL106";

                case AplicacionPermiso.Promociones:
                    return "APL107";

                case AplicacionPermiso.Clientes:
                    return "APL108";

                case AplicacionPermiso.UsuariosPerfiles:
                    return "APL109";

                case AplicacionPermiso.VentaBoletos:
                    return "APL110";

                case AplicacionPermiso.CancelacionBoletos:
                    return "APL111";

                case AplicacionPermiso.Reportes:
                    return "APL112";

                default:
                    return null;
            }
        }

        private static string ObtenerNombreAccion(
            AccionPermiso accion)
        {
            switch (accion)
            {
                case AccionPermiso.Mantenimiento:
                    return "mantenimiento";

                case AccionPermiso.Eliminar:
                    return "eliminar";

                case AccionPermiso.Registrar:
                    return "registrar";

                case AccionPermiso.Modificar:
                    return "modificar";

                default:
                    return null;
            }
        }
    }
}

/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 16/08/2026 */