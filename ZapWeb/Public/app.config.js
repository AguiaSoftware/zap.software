/**
 * Configuration Globais
 */
Application.config({

    ajax: {
        contentType: 'application/json'
    },

    textbox: {
        classes: 'form-control'
    },

    textarea: {
        classes: 'form-control'
    },

    button: {
        classes: 'btn btn-sm'
    },

    checkbox: {
        classes: 'checkbox-inline i-checks'
    }
});

PI.Url.add('BaseUrl', PI.Url.create(window.location.toString()).href());

PI.Url.add('App', 'BaseUrl', '/Public');
PI.Url.add('Modules', 'App', '/modules');
PI.Url.add('Lib', 'App', '/lib');
PI.Url.add('UI', 'Lib', '/pillar/ui');
PI.Url.add('DataTime', 'Lib', '/datatime');
PI.Url.add('Tips', 'Lib', '/tips');
PI.Url.add('Scroll', 'Lib', '/scroll');

/**
 * Alias Url
 */
//PI.Url.add('Grupo', 'Modules', '/grupo');