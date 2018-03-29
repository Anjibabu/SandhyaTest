var propertyOwnerInfo = (function () {

	var publicMethods = {};

	publicMethods.init = function () {

		$('#ddTransTypes').change(function () {

			var selected = $("#ddTransTypes").find("option:selected").text();  

			if (selected == "Property Owner Organization") {
				$("#PropertyOwnerIndividualPage").hide();
				$("#btnBack").hide();
				$("#PropertyOwnerInformation").show();
			}
			else if (selected == "Property Owner Individual") {
				$("#PropertyOwnerInformation").hide();
				$("#btnBack").hide();
				$("#PropertyOwnerIndividualPage").show();
				//} else if (selected == "Contact Person") {
				//	$("#PropertyOwnerInformation,#PropertyOwnerIndividualPage").hide();
				//	$("#ContactPerson").show();
			}
			else {
				$("#PropertyOwnerInformation,#PropertyOwnerIndividualPage").hide();
			}


		});
		//qualify.onTransactionTypeChange();

		propertyOwnerInfo.autoCompleteInit();
	}

	publicMethods.getType = function () {
		var ddPropertyOwnerType = $("#ddTransTypes").val();
		var type = ""
		if (ddPropertyOwnerType == "Property Owner Organization") {
			type = "ORG";
		} else {
			type = "Ind";
		}
		return type;
	}

	publicMethods.autoCompleteInit = function () {
		$("#serachText1").autocomplete({
			source: function (request, response) {
				$.ajax({
					url: "/PropertyOwnerInfo/GetStackHolder",
					type: "POST",
					dataType: "json",
					data: { stackHolder: request.term, type: propertyOwnerInfo.getType() },
					success: function (data) {
						response($.map(data, function (item) {
							console.log(item);
							var type = propertyOwnerInfo.getType();
							var labelName = "No Item";
							if (type == "ORG") {
								labelName = item.OrgName;
							} else {
								labelName = item.FirstName;
							}
							return { label: labelName, value: labelName, address: item };
						}))

					}
				})
			},
			select: function (e, i) {
				console.log(i.item.address);
				var ads = i.item.address;

				var type = propertyOwnerInfo.getType();
				if (type == "ORG") {
					$("#OrganizationName").val(ads.OrgName);
					$("#Authority").val(ads.OrgAuthority);
				} else {
					$("#FirstName").val(ads.FirstName);
					$("#LastName").val(ads.LastName);
					$("#MiddleName").val(ads.MiddleName);
					$("#Suffix").val(ads.Suffix);
				}
				propertyOwnerInfo.resetAddressControls();
				$("#AddressInfo_Address1").val(ads.Address1);
				$("#AddressInfo_Address2").val(ads.Address2);
				$("#AddressInfo_City").val(ads.City);
				$("#AddressInfo_CountyId").val(ads.CountyId);
				$("#AddressInfo_StateId").val(ads.StateId);
				$("#AddressInfo_Zip").val(ads.Zip);
				$("#AddressInfo_CountryId").val(ads.CountryId);
				$("#AddressInfo_Zip4Format").val(ads.Zip4Format);

			},
			minLength: 3,
			messages: {
				noResults: "", results: function (resultsCount) { }
			}
		});
	}

	publicMethods.onTransactionTypeChange = function () {
		var selectedType = $("#ddTransTypes").find("option:selected").text();
		if (selected == "Property Owner Organization") {
			$("#PropertyOwnerIndividualPage").hide();
			$("#btnBack").hide();
			$("#PropertyOwnerInformation").show();
		}
		else if (selected == "Property Owner Individual") {
			$("#PropertyOwnerInformation").hide();
			$("#btnBack").hide();
			$("#PropertyOwnerIndividualPage").show();
		}
		else {
			$("#PropertyOwnerInformation,#PropertyOwnerIndividualPage").hide();
		}
	}

	publicMethods.resetAddressControls = function() {
		$("#AddressInfo_Address1").val("");
		$("#AddressInfo_Address2").val("");
		$("#AddressInfo_City").val("");
		$("#AddressInfo_CountyId").val("");
		$("#AddressInfo_StateId").val("");
		$("#AddressInfo_Zip").val("");
		$("#AddressInfo_CountryId").val("");
		$("#AddressInfo_Zip4Format").val("");
	}
	publicMethods.validate = function () {
		var isValid = common.validate("PropertyOwnerForm");
		return isValid;
	}


	publicMethods.onNextBtnClick = function () {
		var selectedValue = $("#ddTransactionType").val();
		if (selectedValue == "Building Permit Application") {
			var ischkEB = $("#chkEB:checked").length == 1;
			var ischkNB = $("#chkNB:checked").length == 1;
			if (ischkEB || ischkNB) {
				window.location.href = 'PropertyOwnerInfo';
			} else {
				$("#ddTransactionType").removeClass("ValidationError");
				alert("Please check any of the check box.")
			}
		} else if (selectedValue == "Demoloition Permit Application") {
			var ischkPD = $("#chkPD:checked").length == 1;
			var ischkED = $("#chkED:checked").length == 1;
			if (ischkPD || ischkED) {
				window.location.href = 'PropertyOwnerInfo';
			} else {
				$("#ddTransactionType").removeClass("ValidationError");
				alert("Please check any of the check box.")
			}

		} else {
			//alert(Please select the transaction type);
			$("#ddTransactionType").addClass("ValidationError");
		}
	}



	return publicMethods;
})();