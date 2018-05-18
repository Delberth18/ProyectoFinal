﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SurfTribeSystem1._0.Conexion
{
    public class Conexion
    {

        /// <summary>
        /// Devulve la cadena de conexión a la db
        /// </summary>
        /// <returns></returns>
        public string CadenaConexion()
        {
            //return @"Data Source=SHOWROOMPC-001\SQL2017;user id=usreprac;password=usreprac;Initial Catalog=EFLOW_ANDROID;Connection Timeout=45;";
            return @"Data Source=localhost\SQLEXPRESS;Initial Catalog=SURF_TRIBE; Integrated Security=true;Connection Timeout=45;";
        }

        public void EjecutarProcedure(string NombreProcedimiento, List<SqlParameter> Parametros)
        {
            try
            {

                using (SqlConnection oCnn = new SqlConnection(CadenaConexion()))
                {
                    oCnn.Open();

                    SqlCommand oCommand = oCnn.CreateCommand();
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.CommandText = NombreProcedimiento;

                    foreach (SqlParameter oParam in Parametros)
                    {
                        oCommand.Parameters.Add(oParam);
                    }

                    oCommand.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable EjecutarProcedimiento(string NombreProcedimiento, List<SqlParameter> Parametros)
        {
            try
            {

                DataTable oResult = new DataTable();

                using (SqlConnection oCnn = new SqlConnection(CadenaConexion()))
                {
                    using (SqlCommand oCmd = new SqlCommand(NombreProcedimiento, oCnn))
                    {
                        oCmd.CommandType = CommandType.StoredProcedure;

                        oCmd.Parameters.AddRange(Parametros.ToArray());

                        oCnn.Open();

                        using (SqlDataAdapter oAdp = new SqlDataAdapter(oCmd))
                        {
                            oAdp.Fill(oResult);
                        }

                    }

                    return oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet EjecutarProcedimientoDS(string NombreProcedimiento, List<SqlParameter> Parametros)
        {
            try
            {

                DataSet oResult = new DataSet();

                using (SqlConnection oCnn = new SqlConnection(CadenaConexion()))
                {
                    using (SqlCommand oCmd = new SqlCommand(NombreProcedimiento, oCnn))
                    {
                        oCmd.CommandType = CommandType.StoredProcedure;

                        oCmd.Parameters.AddRange(Parametros.ToArray());

                        oCnn.Open();

                        using (SqlDataAdapter oAdp = new SqlDataAdapter(oCmd))
                        {
                            oAdp.Fill(oResult);
                        }

                    }

                    return oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public DataTable EjecutarConsultaTable(string Sql)
        {
            try
            {
                DataTable oTable = new DataTable();

                using (SqlConnection oCnn = new SqlConnection(CadenaConexion()))
                {

                    using (SqlDataAdapter oAdapter = new SqlDataAdapter(Sql, oCnn))
                    {
                        oCnn.Open();
                        oAdapter.Fill(oTable);
                    }
                }

                return oTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet EjecutarConsultaSimple(string consulta)
        {
            try
            {

                DataSet oResult = new DataSet();

                using (SqlConnection oCnn = new SqlConnection(CadenaConexion()))
                {
                    using (SqlCommand oCmd = new SqlCommand(consulta, oCnn))
                    {

                        oCnn.Open();

                        using (SqlDataAdapter oAdp = new SqlDataAdapter(oCmd))
                        {
                            oAdp.Fill(oResult);
                        }

                    }

                    return oResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}