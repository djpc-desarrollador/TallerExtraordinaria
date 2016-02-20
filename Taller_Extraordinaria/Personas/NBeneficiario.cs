using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Data;
using Taller_Extraordinaria.Datos;

namespace Software 
{
    public class NBeneficiario
    {
        private PolancoFinalEntities controlBeneficiario = new PolancoFinalEntities();

        public List<Beneficiario> listarBeneficiarioCodigo(int icodigo)
        {
            List<Beneficiario> lresult = new List<Beneficiario>();
            lresult = controlBeneficiario.Beneficiario.Where(b => b.IdAsociado == icodigo).ToList();
            return lresult;
        }
        public bool RegistrarBeneficiario(Beneficiario benef)
        {
            bool bresult = false;
            try
            {
                this.controlBeneficiario.Beneficiario.Add(benef);
                this.controlBeneficiario.SaveChanges();
                bresult = true;
            }
            catch (Exception)
            {
                throw;
            }
            return bresult;
        }

        // VALIDAR EL REGISTRO SI CUMPLEN CON LA EDAD ESTABLECIDA POR LA EMPRESA, PARA PADRES MAYORES
        // A 65 AÑOS Y PARA HIJOS MENORES DE 25
        public bool ValidarRegistro(string parentesco, int edad)
        {
            bool bresult = true;
            if ((parentesco == "PADRE") || (parentesco == "MADRE"))
            { 
                if (edad < 40)
                {
                    return bresult = false;
                }
            }
            if (parentesco == "HIJO(A)") 
            {
                if (edad >= 25)
                {
                    return bresult = false;
                }
            }
            return bresult;
        }

        // VALIDAR EXISTENCIAS DE PARENTESCO, PADRE MADRE ESPOSO SOLO PUEDE EXISTIR UNO 1
        public bool ValidarParentescos(string parentesco, int idAsociado)
        {
            bool bresult = true;
            Beneficiario aux = new Beneficiario();
            aux = null;
            if ((parentesco == "PADRE") || (parentesco == "MADRE") || (parentesco == "ESPOSO(A)"))
            {
                aux = controlBeneficiario.Beneficiario.Where(b => b.IdAsociado == idAsociado).Where(c => c.Parentesco.Descripcion == parentesco).FirstOrDefault();
            }
            if (aux != null)
            {
                return bresult = false;
            }
            return bresult;
        }

        // RETORNA LA ENTIDAD DEL BENEFICIARIO POR SU ID
        public Beneficiario DevolverBeneficiario(int codigo)
        {
            Beneficiario beneficiario = new Beneficiario();
            beneficiario = this.controlBeneficiario.Beneficiario.Where(c => c.Id == codigo).FirstOrDefault();
            return beneficiario;
        }

        // MODIFICA LA INFORMACION DEL ASOCIADO
        public bool ModificarBeneficiario(Beneficiario updateBeneficiario)
        {
            bool bresult = false;
            try
            {
                this.controlBeneficiario.Beneficiario.Attach(updateBeneficiario);
                this.controlBeneficiario.Entry(updateBeneficiario).State = EntityState.Modified;
                this.controlBeneficiario.SaveChanges();
                bresult = true;
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return bresult;
        }
    }
}
