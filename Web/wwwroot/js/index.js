import React from "react";
import ReactDOM from "react-dom";
import './index.scss';

class App extends React.Component {
    render() {
        return (
            <div>
                <h1>React Timesheet</h1>
                <div>bla bla</div>
            </div>
        )
    }
};

ReactDOM.render(<App />, document.getElementById("app"));