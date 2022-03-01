using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BL
{
    public class Materia
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            using (DL.Models.Context context = new DL.Models.Context())
            {
                var materias = context.Materias.ToList();

                foreach(var obj in materias)
                {
                    ML.Materia materia = new ML.Materia();
                    materia.IdMateria = obj.IdMateria;
                    materia.Nombre = obj.Nombre;
                    materia.Descripcion = obj.Descripcion;
                    materia.Creditos = obj.Creditos;

                }

                string sql = "EXEC MateriaGetAll";
                //var list = context.Materias.FromSqlRaw<DL.Models.Materia>(sql).ToList();



            }

            return result;
        }

        public static ML.Result GetById(int IdMateria)
        {
            ML.Result result = new ML.Result();

            using (DL.Models.Context context = new DL.Models.Context())
            {
                var materiaDb = context.Materias.Where(c=>c.IdMateria==IdMateria).FirstOrDefault();

                ML.Materia materia = new ML.Materia();
                materia.IdMateria = materiaDb.IdMateria;
                materia.Nombre = materiaDb.Nombre;
                materia.Descripcion = materiaDb.Descripcion;


                List<DL.Models.Materia> list;
                string sql = "EXEC MateriaGetById @IdMateria";

                List<SqlParameter> parms = new List<SqlParameter>
                {
                    new SqlParameter { ParameterName = "@IdMateria", Value = IdMateria }
                };


                list = context.Materias.FromSqlRaw<DL.Models.Materia>(sql, parms.ToArray()).ToList();
            }

            return result;
        }

        public static ML.Result Add(ML.Materia materia)
        {
            ML.Result result = new ML.Result();

            using (DL.Models.Context context = new DL.Models.Context())
            {
                context.Materias.Add(
                    new DL.Models.Materia
                    {
                        Nombre=materia.Nombre,
                        Creditos=materia.Creditos,
                        Descripcion=materia.Descripcion
                    });
                context.SaveChanges();

              
            }

            return result;
        }
    }
}
