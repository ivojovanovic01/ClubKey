import React, { Component } from "react";
import UserInformation from "./userInformation";
import PaymentMethods from "./paymentMethods";
import OrderReview from "./orderReview";
import "../../styles/style_payment.css";
import {
	addTicket,
	getCityByEventId,
	getPaymentMethodsByUserId,
	getEventById,
	getUserById
} from "./apiRequests";

class BuyingScreenView extends Component {
	state = {
	city: null,
	user: null,
	numberOfTickets: 1,
	loadings: { loadingCity: true, loadingEvent: true, loadingCity: true }
	};

	componentDidMount() {
		this.getUser();
		this.getUser();
		this.getEventAndCity();
		this.getPaymentMethods();
		this.getEvent();
	}

	getUser = () => {
		getUserById(localStorage.getItem("user")).then(user => {
			this.setState({user});
			this.setState({ ...this.state.loadings, loadingUser: false });
		});
	};

	getEventAndCity = () => {
		getEventById(window.location.pathname).then(event => {
			this.setState({event});
			this.setState({ ...this.state.loadings, loadingEvent: false });
		});
	};

	getCity = () => {
		getCityByEventId(this.props.event).then(city => {
		this.setState({ city });
		this.setState({ ...this.state.loadings, loadingCity: false });
		});
	};

	getPaymentMethods = () => {
	getPaymentMethodsByUserId(this.props.user).then(paymentMethods => {
		this.setState({ paymentMethods });
		this.setState({ ...this.state.loadings, loadingPaymentMethods: false });
	});
	};

	handleBuying = () => {
	for (let i; i < this.state.numberOfTickets; i++) {
		addTicket(this.props.user.id, this.props.event.id, this.props.event.price);
	}
	};

	render() {
	const { user, loadings, paymentMethods, city, numberOfTickets } = this.state;
	return (
		<div>
		{loadings.loadingUser || user === undefined ? 
		<div>Loading User...</div>: 
		<UserInformation user={user} />}
		<PaymentMethods
			addPayment={this.handleAddPaymentMethod}
			paymentMethods={paymentMethods}
		/>
		{
			loadings.loadingCity || loadings.loadingEvent || city === undefined || event === undefined?
			<div>Loading Order Review...</div>: 
			<OrderReview
			event={this.props.event}
			city={city}
			numberOfTickets={numberOfTickets}
			/>
		}
		<section className="discount-code">
			<h6 className="discount-code-title">Discount code:</h6>
			<input type="text" placeholder="Code..." className="input-field" />
		</section>
		<button
			onClick={this.handleBuying}
			className="purple-button full-width"
		>
			BUY NOW
		</button>
	</div>
);
}
}

export default BuyingScreenView;
