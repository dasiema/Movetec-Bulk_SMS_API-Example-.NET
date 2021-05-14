<div class="col-lg-12 alerts">
    <div id="custom-alerts">

        @code
            If Session("SuccessMsg") <> Nothing Then
                @<div class="alert alert-success alert-dismissable">
                    <button aria-hidden="true" data-dismiss="alert" class="close" type="button">×</button>
                    <h4>    <i class="icon fa fa-check"></i> Success</h4>
                    @Session("SuccessMsg")
                </div>
            End If

            If Session("ErrorMsg") <> Nothing Then
                @<div class="alert alert-danger alert-dismissable">
                    <button aria-hidden="true" data-dismiss="alert" class="close" type="button">×</button>
                    <h4>    <i class="icon danger"></i> Error</h4>
                    @Session("ErrorMsg")
                </div>
            End If

            If Session("WarningMsg") <> Nothing Then
                @<div class="alert alert-warning alert-dismissable">
                    <button aria-hidden="true" data-dismiss="alert" class="close" type="button">×</button>
                    <h4>    <i class="icon warning"></i> Warning</h4>
                    @Session("WarningMsg")
                </div>
            End If

            If Session("InfoMsg") <> Nothing Then
                @<div class="alert alert-info alert-dismissable">
                    <button aria-hidden="true" data-dismiss="alert" class="close" type="button">×</button>
                    <h4>    <i class="icon info"></i> Info</h4>
                    @Session("InfoMsg")
                </div>
            End If


        End Code





    </div>
</div>

