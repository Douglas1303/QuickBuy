import { Component} from "@angular/core"

@Component({
  selector: "app-produto", //Em qual tag html será renderizado o componente
  template: "" //
})


              //Nome das classes começam com maiusculo(PascalCase)
export class ProdutoComponent { //export é como se fosse public

  //Nome das variaveis começam com minusculo(camelCase)
  public nome: string;
  public liberadoParaVenda: boolean; 

  public ObterNome(): string { //Metodo que retorna uma string 
    return this.nome; 
  }

}
