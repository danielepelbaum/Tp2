namespace TrabajoPractico2.Models;

public class Receta
{
    public string nombre {get;set;}
    public DateTime fechaNacimiento {get;set;}
    public string tipoComida {get;set;}
    public int presupuesto {get;set;}
    public int cantPersonas {get;set;}

    public int CalcularEdad(){
        int edad = DateTime.Today.Year - fechaNacimiento.Year;
        if(DateTime.Today.Month > fechaNacimiento.Month && DateTime.Today.Day > fechaNacimiento.Day){
            edad +=1
        }
        return edad;
    }
    public string DeterminarPlato(){
        if(tipoComida == "caliente"){
            if(presupuesto<3000){
                return "fideos con manteca";
            }
            else if (presupuesto>3000 && presupuesto<7000){
                return "arroz con verduras salteadas";
            }
            else if (presupuesto>7000){
                return "pollo al horno con guarnicion";
            }
        }
        else if (tipoComida == "frio"){
            if (presupuesto<3000){
                return "ensalada simple";
            }
            else if (presupuesto>3000 && presupuesto<7000){
                return "ensalada completa con proteina";
            }
            else if (presupuesto>7000){
                return "tabla de fiambres y quesos";
            }
        }
    }
    public int CalcularTiempo(){

        if(tipoComida== "caliente" && (cantPersonas==1 || cantPersonas == 22 || cantPersonas== 3)){
            return 20;
        }

        else if ( tipoComida == "caliente" && cantPersonas >= 4 && cantPersonas <= 7){
            return 40;
        }

        else if (tipoComida == "caliente" && cantPersonas >= 8){
            return 80;
        }

        else if (tipoComida == "fria" &&cantPersonas>=1 && cantPersonas <=3){
            return 10;
        }

        else if(tipoComida== "fria" && cantPersonas >=4 && cantPersonas <=7){
            return 20;
        }

        else if(tipoComida == "fria" && cantPersonas >= 8){
            return 40;
        }
    }

    public string DeterminarDificultad(){
        if(presupuesto < 3000){
            if (cantPersonas>=1 && cantPersonas <=3){
                return "principiante";
            }
            else if (cantPersonas >=4 || cantPersonas <=7){
                return "intermedio";
            }
        }
        if(presupuesto >=3000 && presupuesto <=7000){
            if(cantPersonas>=1 && cantPersonas <=3){
                return "intermedio";
            }
            else if (cantPersonas>=4 && cantPersonas<=7){
                return "intermedio";
            }
        }
    }
    public string GenerarSaludo(){
        if(DateTime.Now.Hour <= 15 && DateTime.Now.Hour >= 7){
            return "Buenos días";
        }
        else if (DateTime.Now.Hour > 15 && DateTime.Now.Hour <= 20){
            return "Buenas tardes";
        }
        else{
            return "Buenas noches";
        }
    }
    public string GenerarTip(){
        if (edad < 18){
            return "Por favor, tenga cuidado.";
        }
        else if (edad >= 60){
            return "DALE BO, DALE BO, este año ganamos la séptima."
        }
        else{
            return "Dale que se puede!";
        }
    }
}