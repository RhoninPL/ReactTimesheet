import React from "react";
import ReactDOM from "react-dom";
import Form from './components/Form';
import './index.scss';

class App extends React.Component {
    render() {
        return (
            <div>
                <h1>React Timesheet</h1>
                <Form>bla bla</Form>
            </div>
        );
    }
};

ReactDOM.render(<App />, document.getElementById("app"));