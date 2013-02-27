//This file should be used if you want to debug and develop
function jqGridInclude()
{
    var pathtojsfiles = "../../Scripts/js/"; // need to be ajusted
    // set include to false if you do not want some modules to be included
    var modules = [
        { include: true, incfile:'i18n/grid.locale-en.js'},
        { include: true, incfile:'grid.base.js'},
        { include: true, incfile:'grid.common.js'},
        { include: true, incfile:'grid.formedit.js'},
        { include: true, incfile:'grid.inlinedit.js'},
        { include: true, incfile:'grid.celledit.js'},
        { include: true, incfile:'grid.subgrid.js'},
        { include: true, incfile:'grid.treegrid.js'},
	    { include: true, incfile:'grid.grouping.js'},
        { include: true, incfile:'grid.custom.js'},
        { include: true, incfile:'grid.tbltogrid.js'},
        { include: true, incfile:'grid.import.js'},
        { include: true, incfile:'jquery.fmatter.js'},
        { include: true, incfile:'JsonXml.js'},
        { include: true, incfile:'grid.jqueryui.js'},
        { include: true, incfile:'grid.filter.js'}
    ];
    var filename;
    for(var i=0;i<modules.length; i++)
    {
        if(modules[i].include === true) {
        	filename = pathtojsfiles+modules[i].incfile;
			if(jQuery.browser.safari) {
				jQuery.ajax({url:filename,dataType:'script', async:false, cache: true});
			} else {
				if (jQuery.browser.msie) {
					document.write('<script charset="utf-8" type="text/javascript" src="'+filename+'"></script>');
				} else {
					IncludeJavaScript(filename);
				}
			}
		}
    }
	function IncludeJavaScript(jsFile)
    {
        var oHead = document.getElementsByTagName('head')[0];
        var oScript = document.createElement('script');
        oScript.setAttribute('type', 'text/javascript');
        oScript.setAttribute('language', 'javascript');
        oScript.setAttribute('src', jsFile);
        oHead.appendChild(oScript);
    }
}
jqGridInclude();
