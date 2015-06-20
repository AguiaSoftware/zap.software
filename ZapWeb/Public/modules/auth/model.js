yum.define(function () {

    Class('Auth.Model').Extend(Mvc.Model.Base).Body({

        instances: function () {
            
        },

        init: function () {
            this.base.init('/auth');
        },

        onValid: function () {
            return {
                'UserName': new Mvc.Model.Validator.Required('O nome do usuário é obrigatório'),
                'Password': new Mvc.Model.Validator.Required('A senha do usuário é obrigatória')
            };
        },

        actions: {
            'entrar': '/entrar'
        },

        sair: function () {
            window.location = '/auth/sair';
        }

    });

});