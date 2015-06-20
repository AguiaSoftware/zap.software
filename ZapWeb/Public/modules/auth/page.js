yum.define([
	PI.Url.create('Auth', '/page.html'),
	PI.Url.create('Auth', '/page.css'),
    PI.Url.create('Auth', '/model.js')
], function (html) {

    Class('Auth.Page').Extend(Mvc.Component).Body({

        instances: function () {
            this.view = new Mvc.View(html);

            this.usuario = new UI.TextBox({
                dataModel: 'UserName',
                placeholder: 'Nome do Usuário'
            });

            this.senha = new UI.TextBox({
                type: 'password',
                dataModel: 'Password',
                placeholder: 'Senha'
            });

            this.entrar = new UI.Button({
                label: 'Entrar',
                classes: 'btn btn-sm btn-success'
            });
        },

        tryLogar: function () {
            var auth = new Auth.Model(),
                label = this.entrar.getLabel(),
                self = this,
                v = this.injectViewToModel(auth);

            if (!v.status) {
                this.view.info.html(v.messages.join('<br/>'));
                return;
            }

            this.entrar.setLabel('Entrando ...').lock();

            auth.entrar().ok(function () {
                window.location = "/home";
            }).error(function () {
                self.entrar.setLabel(label).unlock();
                self.view.info.html('Usuário ou Senha Incorreta');
            });
        },

        events: {

            '{entrar} click': function () {
                this.tryLogar();
            },

            '{usuario} enter': function () {
                this.tryLogar();
            },

            '{senha} enter': function () {
                this.tryLogar();
            }

        }

    });

});