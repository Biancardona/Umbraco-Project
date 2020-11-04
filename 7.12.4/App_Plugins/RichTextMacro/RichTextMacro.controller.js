angular.module("umbraco")
    .controller("Macro.RichTextMacro",
        function ($scope) {
            $scope.textInput = {
                label: 'bodyText',
                description: '...',
                view: 'rte',
                value: $scope.model.value,
                config: {
                    editor: {
                        toolbar: ["code", "removeformat", "forecolor", "fontselect", "fontsizeselect", "link", "unlink", "bold", "italic", "underline", "strikethrough", "undo", "redo", "cut", "styleselect", "alignleft", "aligncenter", "alignright", "bullist", "numlist", "umbmediapicker", "table", "umbembeddialog", "charmap"],
                        stylesheets: ["rte"],
                        dimensions: {
                            height: 200
                        }
                    }
                }
            };
            $scope.$watch('textInput.value', function (newValue, oldValue) {
                $scope.model.value = newValue;
            });
        });