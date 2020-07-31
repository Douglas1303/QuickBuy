import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../model/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html", //qual é meu html
  styleUrls: ["./login.component.css"] //qual é a folha de estilo
})
export class LoginComponent implements OnInit {
  public usuario;
  public returnUrl: string; 
 

  constructor(private router: Router, private activateRouter: ActivatedRoute,
              private usuarioServico: UsuarioServico) {
    
     
  }
    ngOnInit(): void {
      this.returnUrl = this.activateRouter.snapshot.queryParams['returnUrl'];
      this.usuario = new Usuario();
    }

  entrar() {

    this.usuarioServico.verificarUsuario(this.usuario)
      .subscribe(
        data => {

        },
        err => {

        }
      ); 

    //if (this.usuario.email == "douglas@teste.com" && this.usuario.senha == "123") {
    //  sessionStorage.setItem("usuario-autenticado", "1");
    //  this.router.navigate([this.returnUrl]); 
    //}
  }
}
