"use strict";

window.initializeDropdowns = function () {
    var dropdownBtn = document.querySelectorAll(".dropdown-btn");
    var dropdown = document.querySelectorAll(".dropdown");
    var hamburgerBtn = document.getElementById("hamburger");
    var navMenu = document.querySelector(".menu");
    var links = document.querySelectorAll(".dropdown a");

    function setAriaExpandedFalse() {
        dropdownBtn.forEach(function (btn) {
            return btn.setAttribute("aria-expanded", "false");
        });
    }

    function closeDropdownMenu() {
        dropdown.forEach(function (drop) {
            drop.classList.remove("active");
            drop.addEventListener("click", function (e) {
                return e.stopPropagation();
            });
        });
    }

    function toggleHamburger() {
        navMenu.classList.toggle("show");
    }

    dropdownBtn.forEach(function (btn) {
        btn.addEventListener("click", function (e) {
            var dropdownIndex = e.currentTarget.dataset.dropdown;
            var dropdownElement = document.getElementById(dropdownIndex);

            dropdownElement.classList.toggle("active");
            dropdown.forEach(function (drop) {
                if (drop.id !== btn.dataset["dropdown"]) {
                    drop.classList.remove("active");
                }
            });
            e.stopPropagation();
            btn.setAttribute("aria-expanded", btn.getAttribute("aria-expanded") === "false" ? "true" : "false");
        });
    });

    links.forEach(function (link) {
        return link.addEventListener("click", function () {
            closeDropdownMenu();
            setAriaExpandedFalse();
            toggleHamburger();
        });
    });

    document.documentElement.addEventListener("click", function () {
        closeDropdownMenu();
        setAriaExpandedFalse();
    });

    document.addEventListener("keydown", function (e) {
        if (e.key === "Escape") {
            closeDropdownMenu();
            setAriaExpandedFalse();
        }
    });
};

